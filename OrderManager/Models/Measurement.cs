using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManager.Models
{
    public class Measurement
    {
        static int id = 0;
        public int Id { get; set; }

        public DateTime MeasuringOrderDate { get; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime MeasuringDate { get; set; }
        public Measurement() { }
        public Measurement(string name, string addr, string phone, DateTime date)
        {
            Id = id++;
            MeasuringOrderDate = DateTime.Now;
            FullName = name;
            Address = addr;
            Phone = phone;
            MeasuringDate = date;
        }

    }
}
