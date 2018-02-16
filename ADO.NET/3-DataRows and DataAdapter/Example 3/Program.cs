using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            var commandStr = "SELECT * FROM Users";

            var connection = new SqlConnection(conStr);
            var command = new SqlCommand(commandStr,connection);
            var users = new  DataTable("Users");

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            adapter.Fill(users);

            foreach (DataRow row in users.Rows)
            {
                foreach (DataColumn column in users.Columns)
                    Console.WriteLine("{0}:{1}",column.ColumnName,row[column]);
                Console.WriteLine();
            }



        }
    }
}
