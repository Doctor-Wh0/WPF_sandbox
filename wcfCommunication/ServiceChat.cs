using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using wcfCommunication.DbAnalog;

namespace wcfCommunication
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ServiceChat : IServiceChat
    {
        List<ServerUser> users = new List<ServerUser>();
        int nextId = 1;
        public int Connect(string name)
        {
            ServerUser user = new ServerUser()
            {
                Id = nextId,
                Name = name,
                operationContext = OperationContext.Current
            };
            SendMsg($"Пользователь {user.Name} подключился к системе",0);
            nextId++;
            users.Add(user);
            return user.Id;
        }

        public void Disconnect(int id)
        {
            var user = users.FirstOrDefault(i => i.Id == id);
            if(user!= null)
            {
                users.Remove(user);
                SendMsg($"Пользователь {user.Name} вышел из системы",0);
            }
        }

        public object GetOrders()
        {
            TextDB db = new TextDB();
            DataSet tables = db.GetOrders();
            return tables;
        }

        public bool SendOrders(Order order)
        {
            throw new NotImplementedException();
        }

        public void SendMsg(string msg, int id)
        {
            users.ForEach(i => {
                string answer = DateTime.Now.ToString();
                var user = users.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    answer += ": " + user.Name + " ";
                }
                answer += msg;
                i.operationContext.GetCallbackChannel<IServiceChatCallback>().MsgCallback(answer);
            });
        }

        
    }
}
