using OrderManager.Commands;
using OrderManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace OrderManager.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        List<UserControl> controls = new List<UserControl>();
        List<Measurement> measurements = new List<Measurement>();
        List<IViewModel> viewModels = new List<IViewModel>();
        //ServiceChat.ServiceChatClient client;
        public ServiceChat.ServiceChatClient Client
        {
            get { return App.client; }
            set { App.client = value; }
        }

        private object selectedViewModel;
        public object SelectedViewModel
        {
            get { return selectedViewModel; }
            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }
        }

        public MainWindowViewModel()
        {
            var homeVM = new HomeViewModel();
            SelectedViewModel = homeVM;
            viewModels.Add(homeVM);
            var chatVM  = new ChatViewModel();
            var ordersVM = new OrdersViewModel();
            var addOrderVM = new AddOrderViewModel();
            viewModels.Add(chatVM);
            viewModels.Add(ordersVM);
            viewModels.Add(addOrderVM);
        }
        ~MainWindowViewModel()
        {
            var chatVM = viewModels.FirstOrDefault(i => i is ChatViewModel);
            if(chatVM != null)
            {
                //chatVM. Dispose methods in IViewModel
            }
        }

        #region commands
        private RelayCommand toHomeCommand;
        public RelayCommand ToHomeCommand
        {
            get
            {
                return toHomeCommand ??
                  (toHomeCommand = new RelayCommand(sender =>
                  {
                      SelectedViewModel = viewModels.FirstOrDefault(i=> i is HomeViewModel);

                  }));
            }
        }
        private RelayCommand toOrdersCommand;
        public RelayCommand ToOrdersCommand
        {
            get
            {
                return toOrdersCommand ??
                  (toOrdersCommand = new RelayCommand(sender =>
                  {
                      SelectedViewModel = viewModels.FirstOrDefault(i => i is OrdersViewModel);

                  }));
            }
        }
        private RelayCommand toAddOrderCommand;
        public RelayCommand ToAddOrderCommand
        {
            get
            {
                return toAddOrderCommand ??
                  (toAddOrderCommand = new RelayCommand(sender =>
                  {
                      SelectedViewModel = viewModels.FirstOrDefault(i => i is AddOrderViewModel);
                  }));
            }
        }
        private RelayCommand toChatCommand;
        public RelayCommand ToChatCommand
        {
            get
            {
                return toChatCommand ??
                  (toChatCommand = new RelayCommand(sender =>
                  {
                      SelectedViewModel = viewModels.FirstOrDefault(i => i is ChatViewModel);

                  }));
            }
        }

        //private RelayCommand tabChangedCommand;
        //public RelayCommand TabChangedCommand
        //{
        //    get
        //    {
        //        return tabChangedCommand ??
        //          (tabChangedCommand = new RelayCommand(sender =>
        //          {
        //              MessageBox.Show("Команда");
        //          }));
        //    }
        //}

        #endregion

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
