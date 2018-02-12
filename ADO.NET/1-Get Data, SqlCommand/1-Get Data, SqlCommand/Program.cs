using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Get_Data__SqlCommand
{
    class Program
    {


        static void Main(string[] args)
        {
            string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            connection.Open();

            var cmd = new SqlCommand("SELECT Users.name FROM Users Where Users.id =2",connection);
            var insertCmd = new SqlCommand("Insert Users Values('Steve')", connection);
            var delCmd = new SqlCommand("Delete Users Where Users.name = 'Steve'",connection);


            insertCmd.ExecuteNonQuery();
            delCmd.ExecuteNonQuery();
            Console.WriteLine((string)cmd.ExecuteScalar());
            connection.Close();
        }
    }
}
