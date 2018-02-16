using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        private static void LoadData(string commandString, string connectionString, DataTable table)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand(commandString, connection);

                var reader = cmd.ExecuteReader();

                table.Load(reader);

                reader.Close();
            }
        }

        private static void SimpleLoadData(string commandString, string connectionString, DataTable table)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var cmd = new SqlCommand(commandString,connection);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    var newRow = table.NewRow();

                    for (int i = 0; i < reader.FieldCount; i++)
                        newRow[i] = reader[i];

                    table.Rows.Add(newRow);
                }
                reader.Close();
            }
        }


        static void Main(string[] args)
        {
            var conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            var commandStr = "SELECT * FROM Users";

            DataTable users = new DataTable();

            LoadData(commandStr, conStr, users);

            for (var i = 0; i < users.Rows.Count; i++)
                Console.WriteLine("Row {0}, RowState: {1}", i, users.Rows[i].RowState);
            
            Console.WriteLine(new string('_', 20));

            users.Clear();
            SimpleLoadData(commandStr, conStr, users);

            for (var i = 0; i < users.Rows.Count; i++)
                Console.WriteLine("Row {0}, RowState: {1}", i, users.Rows[i].RowState);
 

        }
    }
}
