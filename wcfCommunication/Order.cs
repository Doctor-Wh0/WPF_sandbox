using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace wcfCommunication
{
    /// <summary>
    /// Класс создан для дальнейшей работы с ADO.NET для пересылки клиентам, создавшим соединение, и запросившими данные через WCF.
    /// </summary>
    [DataContract]
    public class Order
    {
        static int id = 0;
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime MeasuringOrderDate { get; set; }
        [DataMember]
        public String FullName{get; set;}
        [DataMember]
        public String City{get; set;}
        [DataMember]
        public String Address{get; set;}
        [DataMember]
        public String Phone{get; set;}
        [DataMember]
        public DateTime MeasuringDate { get; set; }
        [DataMember]
        public Boolean IsDone { get; set; }
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
    }
}
