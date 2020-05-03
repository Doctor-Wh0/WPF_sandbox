using OrderManager.Models;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace OrderManager.ViewModels
{
    public class OrdersViewModel : IViewModel
    {
        ObservableCollection<Order> orders{get; set;}

        public ObservableCollection<Order> Orders
        {
            get
            {
                return orders;
            }
            set
            {
                orders = value;
                OnPropertyChanged("Orders");
            }
        }

        public Order SelectedOrder;
        public OrdersViewModel()
        {
            
            orders = new ObservableCollection<Order>{
                new Order{ Id = 0, City="Саратов", Address="Moskovskaya 46", FullName="Ivan Ivanovich Ivanov", MeasuringDate = DateTime.Now, Phone="272727", IsDone=false},
                new Order{ Id = 1, City="Саратов", Address="Moskovskaya 47", FullName="Ivan Ivanovich Lisko", MeasuringDate = DateTime.Now, Phone="272728", IsDone=false},
                new Order{ Id = 2, City="Саратов", Address="Moskovskaya 47", FullName="Ivan Ivanovich Somatov", MeasuringDate = DateTime.Now, Phone="272729", IsDone=false},
                new Order{ Id = 3, City="Саратов", Address="Moskovskaya 48", FullName="Ivan Ivanovich Egorov", MeasuringDate = DateTime.Now, Phone="272730", IsDone=false},
            };
            orders.CollectionChanged += Orders_CollectionChanged;
        }

        private static void Orders_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (App.client != null)
            {
                object obj = App.client.GetOrders();
            }
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add: // если добавление
                    Order newUser = e.NewItems[0] as Order;
                    Console.WriteLine($"Добавлен новый объект: {newUser.FullName}");
                    break;
                case NotifyCollectionChangedAction.Remove: // если удаление
                    Order oldUser = e.OldItems[0] as Order;
                    Console.WriteLine($"Удален объект: {oldUser.FullName}");
                    break;
                case NotifyCollectionChangedAction.Replace: // если замена
                    Order replacedUser = e.OldItems[0] as  Order;
                    Order replacingUser = e.NewItems[0] as Order;
                    Console.WriteLine($"Объект {replacedUser.FullName} заменен объектом {replacingUser.FullName}");
                    break;
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
