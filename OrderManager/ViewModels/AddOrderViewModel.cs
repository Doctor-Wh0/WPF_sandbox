using OrderManager.Commands;
using OrderManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
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
                new Restriction{ City="Саратов", DateTimeInfo=DateTime.Now, RestrictionsCount=4},
                new Restriction{ City="Волгоград", DateTimeInfo=DateTime.Now, RestrictionsCount=5}
            };
            Application.Current.Resources.Add("Restrictions", restrictions.ToList<Restriction>());
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
                      if (!(obj is Restriction)) return;
                      var r = obj as Restriction;
                      //Restrictions.Add(r);
                      Application.Current.Resources["Restrictions"] = Restrictions;
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
