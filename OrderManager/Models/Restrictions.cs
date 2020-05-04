using System;
using GalaSoft.MvvmLight;

namespace OrderManager.Models
{
    public class Restriction : ObservableObject
    {
        String _city;
        public String City
        {
            get { return _city; }
            set
            {
                    this.Set(() => City, ref _city, value);
            }
        }
        DateTime _dateTime;
        public DateTime DateTimeInfo
        {
            get { return _dateTime; }
            set
            {
                this.Set(() => DateTimeInfo, ref _dateTime, value);
            }
        }

        int _restrictions;
        public int RestrictionsCount
        {
            get { return _restrictions; }
            set
            {
                this.Set(() => RestrictionsCount, ref _restrictions, value);
            }
        }

        public Restriction() { }
        public Restriction(String city, DateTime date, int restrictions)
        {
            _city = city;
            _dateTime = date;
            _restrictions = restrictions;
        }
    }
}
