using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace OrderManager.Models
{
    public class Order : ObservableObject
    {
        #region properties
        static int id = 0;
        int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                this.Set(() => Id, ref _id, value);
            }
        }

        DateTime _measuringOrderDate;
        public DateTime MeasuringOrderDate
        {
            get { return _measuringOrderDate; }
            set
            {
                this.Set(() => MeasuringOrderDate, ref _measuringOrderDate, value);
            }
        }
        String _fullName;
        public String FullName
        {
            get { return _fullName; }
            set
            {
                this.Set(() => FullName, ref _fullName, value);
            }
        }
        string _city;
        public String City
        {
            get { return _city; }
            set
            {
                this.Set(() => City, ref _city, value);
            }
        }
        string _address;
        public String Address
        {
            get { return _address; }
            set
            {
                this.Set(() => Address, ref _address, value);
            }
        }
        String _phone;
        public String Phone
        {
            get { return _phone; }
            set
            {
                this.Set(() => Phone, ref _phone, value);
            }
        }
        DateTime _measuringDate;
        public DateTime MeasuringDate
        {
            get { return _measuringDate; }
            set
            {
                this.Set(() => MeasuringDate, ref _measuringDate, value);
            }
        }
        Boolean _isDone;
        public Boolean IsDone
        {
            get { return _isDone; }
            set
            {
                this.Set(() => IsDone, ref _isDone, value);
            }
        }

        #endregion
        public Order() { }
        public Order(String name, String addr, String city, String phone, DateTime date)
        {
            Id = id++;
            MeasuringOrderDate = DateTime.Now;
            FullName = name;
            City = city;
            Address = addr;
            Phone = phone;
            MeasuringDate = date;
            IsDone = false;
        }


        //private int id;
        //private string name;
        //private bool selected;

        //public int Id
        //{
        //    get
        //    {
        //        return this.id;
        //    }
        //    set
        //    {
        //        this.Set(() => Id, ref id, value);
        //    }
        //}

        //public string Name
        //{
        //    get
        //    {
        //        return this.name;
        //    }
        //    set
        //    {
        //        this.Set(() => Name, ref name, value);
        //    }
        //}

        //public bool Selected
        //{
        //    get
        //    {
        //        return this.selected;
        //    }
        //    set
        //    {
        //        this.Set(() => Selected, ref selected, value);
        //    }
        //}

        //public Order(int id, string name)
        //{
        //    this.id = id;
        //    this.name = name;
        //}
    }
}
