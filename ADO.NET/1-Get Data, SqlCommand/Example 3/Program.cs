using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example_3
{
    class Program
    {
        private static string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";


        static async void GetDataAsync()
        {
            using (var connection = new SqlConnection(conStr))
            {
                await connection.OpenAsync();
                var command = new SqlCommand("WAITFOR DELAY '00:00:05'",connection);
                await command.ExecuteNonQueryAsync();
                Console.WriteLine("Async operation complete");
            }
        }

        static void GetData()
        {
            using(var connection = new SqlConnection(conStr))
            {
                connection.Open();
                var command = new SqlCommand("WAITFOR DELAY '00:00:05'", connection);
                command.ExecuteNonQuery();
                Console.WriteLine("Non async operation complete");
            }
        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("[]");
            }
            GetData();
            for (int i = 0; i < 20; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("[]");
            }
            GetDataAsync();
            for (int i = 0; i < 200; i++)
            {
                Thread.Sleep(100);
                Console.WriteLine("[]");
            }
           
        }
    }
}
