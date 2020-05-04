using OrderManager.Commands;
using OrderManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace OrderManager.ViewModels
{
    public class AddOrderViewModel : IViewModel
    {
        ObservableCollection<Restriction> restrictions { get; set; }
        public ObservableCollection<Restriction> Restrictions
        {
            get
            {
                return restrictions;
            }
            set
            {
                restrictions = value;
                OnPropertyChanged("Restrictions");
            }
        }
        public AddOrderViewModel()
        {
            restrictions = new ObservableCollection<Restriction>
            {
                new Restriction { City="Москва", DateTimeInfo=DateTime.Now, RestrictionsCount=5},
                new Restriction{ City="Саратов", DateTimeInfo=DateTime.Now, RestrictionsCount=6},
                new Restriction{ City="Волгоград", DateTimeInfo=DateTime.Now, RestrictionsCount=5}
            };
            Application.Current.Resources.Add("Restrictions", restrictions);
        }

        #region
        private RelayCommand editDate;
        public RelayCommand EditDate
        {
            get
            {
                return editDate ??
                  (editDate = new RelayCommand(obj =>
                  {
                      //DateTime date = (DateTime)obj;
                      Console.WriteLine(    "OKKK");
                  }));
            }
        }

        #endregion


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
