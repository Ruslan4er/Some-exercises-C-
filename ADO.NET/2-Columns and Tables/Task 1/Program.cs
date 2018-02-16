using System;
using System.Collections.Generic;
using System.Data;
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


            DataSet dataSet = new DataSet();
            DataTable oders = new DataTable("Oders");
            DataTable users = new DataTable("Users");

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                connection.Open();
                var usersCmd = new SqlCommand("SELECT * FROM Users", connection);
                var odersCmd = new SqlCommand("SELECT * FROM Oders", connection);

                var odersReader = odersCmd.ExecuteReader();
                oders.LoadWithSchema(odersReader);
                odersReader.Close();

                var usersReader = usersCmd.ExecuteReader();
                users.LoadWithSchema(usersReader);
                usersReader.Close();
            }

            dataSet.Tables.AddRange(new DataTable[]{users,oders});
            //users.PrimaryKey = new DataColumn[]{users.Columns[0]};

            var FK_UsersOders = new ForeignKeyConstraint(users.Columns["id"],oders.Columns["user_id"]);
           // oders.Constraints.Add(FK_UsersOders);
        }
    }
}
