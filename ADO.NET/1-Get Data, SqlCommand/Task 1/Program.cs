using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);

            //SqlCommand readData = new SqlCommand("SELECT * FROM Users ", connection);
            SqlCommand readData = new SqlCommand("SELECT Oders.id, Oders.Cost, Users.name" +
                                                 " FROM Oders JOIN Users ON Users.id=Oders.User_id ", connection);


            connection.Open();
            var reader = readData.ExecuteReader();
            ReadAllData(reader);
            reader.Close();
            connection.Close();
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
    }
}
