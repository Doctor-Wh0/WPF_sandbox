using System;
using System.Data;
using System.Data.OleDb;
using System.ServiceModel;
using wcfCommunication;

namespace OrderCommunicationHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(wcfCommunication.ServiceChat)))
            {
                host.Open();

                //OleDbConnection StrCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\projects;Extended Properties=text");
                //string Select1 = "SELECT * FROM [OrdersDataBase.txt]";
                //OleDbCommand Command1 = new OleDbCommand(Select1, StrCon);

                //OleDbDataAdapter Adapter1 = new OleDbDataAdapter(Command1);
                //DataSet AllTables = new DataSet();
                //StrCon.Open();
                //Adapter1.Fill(AllTables);
                //StrCon.Close();
                //var empList = AllTables.Tables[0].AsEnumerable()
                //        .Select(dataRow => new Order
                //        {
                //            FullName = dataRow.Field<string>("FullName"),
                //            Id = dataRow.Field<int>("Id"),
                //            Phone = dataRow.Field<string>("Phone"),
                //            Address = dataRow.Field<string>("Address"),
                //            City = dataRow.Field<string>("City"),
                //            MeasuringDate = dataRow.Field<DateTime>("MeasuringDate"),
                //            MeasuringOrderDate = dataRow.Field<DateTime>("MeasuringOrderDate")
                //        });

                System.Console.WriteLine("Хост запущен");
                Console.ReadLine();
            }
        }
    }
}
