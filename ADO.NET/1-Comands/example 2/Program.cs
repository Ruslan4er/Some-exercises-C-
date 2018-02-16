using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            var command = new SqlCommand("SELECT * FROM Users", connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.WriteLine(reader.GetName(i) + ":" + reader[i]);
                }
                Console.WriteLine(new string('_', 20));
            }
            reader.Close();
            connection.Close();
        }
    }
}
