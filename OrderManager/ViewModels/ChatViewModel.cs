using OrderManager.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace OrderManager.ViewModels
{
    public class ChatViewModel : IViewModel, OrderManager.ServiceChat.IServiceChatCallback
    {
        public ObservableCollection<string> Messages { get; set; }
        //ServiceChat.ServiceChatClient client;
        public ServiceChat.ServiceChatClient Client
        {
            get { return App.client; }
            set { App.client = value; }
        }
        bool IsConnected = false;
        int ID;
        string conDiscon = "Войти";
        string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                if (!IsConnected)
                {
                    userName = value;
                }
            }
        }
        public string ConDiscon
        {
            get { return conDiscon; }
           private set
            {
                conDiscon = value;
                OnPropertyChanged("ConDiscon");
            }
        }
        public ChatViewModel()
        {
            Messages = new ObservableCollection<string>();
            //client = new ServiceChat.ServiceChatClient(new System.ServiceModel.InstanceContext(this));
        }
        ~ChatViewModel()
        {
            if (IsConnected)
            {
                DisconnectUser();
                Client = null;
            }
        }

        void ConnectUser()
        {
            if (!IsConnected)
            {
                Client = new ServiceChat.ServiceChatClient(new System.ServiceModel.InstanceContext(this));
                ID = Client.Connect(UserName);
                IsConnected = true;
                ConDiscon = "Выйти";
            }
        }

        void DisconnectUser()
        {
            if (IsConnected)
            {
                Client.Disconnect(ID);
                Client = null;
                IsConnected = false;
                ConDiscon = "Войти";
            }
        }


        #region commands

        private RelayCommand conDisconCommand;
        public RelayCommand ConDisconCommand
        {
            get
            {
                return conDisconCommand ??
                  (conDisconCommand = new RelayCommand(obj =>
                  {
                      if (IsConnected)
                      {
                          DisconnectUser();
                      }
                      else {
                          UserName = obj as string;
                          ConnectUser();
                      }
                  }));
            }
        }


        private RelayCommand sendMessageCommand;
        public RelayCommand SendMessageCommand
        {
            get
            {
                return sendMessageCommand ??
                  (sendMessageCommand = new RelayCommand(obj =>
                  {
                      if(Client!=null)
                     Client.SendMsg(obj as string,ID);
                  }));
            }
        }
        #endregion


        public void MsgCallback(string msg)
        {
            Messages.Add(msg);
        }




        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


    }
}
