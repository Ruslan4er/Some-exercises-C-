using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_DataRows_and_DataAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();

            table.Columns.Add(new DataColumn("Column1"));

            DataRow row = table.NewRow();
            row[0] = "Test";
            Console.WriteLine(row.RowState);

            table.Rows.Add(row);
            Console.WriteLine(row.RowState);

            //table.AcceptChanges();
            table.RejectChanges();
            Console.WriteLine(row.RowState);
        }
    }
}
