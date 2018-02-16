using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        private static string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";

        static async void GetDataAsync()
        {
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                var command = new SqlCommand("FindUser", connection){CommandType = CommandType.StoredProcedure};
                await connection.OpenAsync();

                Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
                Console.WriteLine("Введите номер пользователя");

                int id = int.Parse(Console.ReadLine());
                command.Parameters.AddWithValue("@id", id);

                var reader = command.ExecuteReaderAsync();
                ReadAllData(await reader);
            }

        }

        static void ReadAllData(SqlDataReader reader)
        {
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.WriteLine(reader.GetName(i) + ":" + reader[i]);
                Console.WriteLine(new string('_', 30));
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Thread.CurrentThread.ManagedThreadId);
            GetDataAsync();
            Thread.Sleep(10000);
            
        }
    }
}
