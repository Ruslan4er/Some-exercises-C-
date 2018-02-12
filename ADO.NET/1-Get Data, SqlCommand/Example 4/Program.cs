using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_4
{
    class Program
    {

        public static void WriteReaderData(SqlDataReader reader)
        {
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    Console.WriteLine(reader.GetName(i) + ":" + reader[i]);
                Console.WriteLine(new string('_',20));
            }

        }

        static void Main(string[] args)
        {
            string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            var command = new SqlCommand("SELECT * FROM Users; SELECT * FROM Oders", connection);
            var reader = command.ExecuteReader();
            WriteReaderData(reader);
            Console.WriteLine(new string('-',20));
            reader.NextResult();
            WriteReaderData(reader);

            reader.Close();
            connection.Close();

        }
    }
}
