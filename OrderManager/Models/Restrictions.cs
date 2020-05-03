using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        int _restrictions;
        public int Restrictions
        {
            get { return _restrictions; }
            set
            {
                this.Set(() => Restrictions, ref _restrictions, value);
            }
        }
        public Restriction(String city, int restrictions)
        {
            _city = city;
            _restrictions = restrictions;
        }
    }
}
