using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace wcfCommunication.DbAnalog
{
    public class TextDB
    {
        public DataSet GetOrders()
        {
            //определить подключение
            OleDbConnection StrCon = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\projects; Extended Properties=Text");
            string Select1 = "SELECT * FROM [OrdersDataBase.txt]";
            OleDbCommand Command1 = new OleDbCommand(Select1, StrCon);

            OleDbDataAdapter Adapter1 = new OleDbDataAdapter(Command1);
            DataSet AllTables = new DataSet();
            StrCon.Open();
            Adapter1.Fill(AllTables);

            return AllTables;
        }
        
    }
}
