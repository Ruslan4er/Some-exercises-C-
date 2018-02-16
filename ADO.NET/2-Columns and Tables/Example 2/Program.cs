using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataTable table = new DataTable();
            var column1 = table.Columns.Add("Column1",typeof(int));
            var column2 = table.Columns.Add("Column2", typeof(int));

            table.Constraints.Add(new UniqueConstraint(column1, true));
            Console.WriteLine(table.PrimaryKey.Length);
            Console.WriteLine(table.PrimaryKey[0]);

        }
    }
}
