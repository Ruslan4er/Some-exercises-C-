using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Microsoft.Build.Framework;

namespace _4_Relations
{
    class Program
    {
        static void Main(string[] args)
        {
            var conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            var commStr = @"SELECT * FROM Users; SELECT * FROM Oders;";

            var universityDB = new DataSet();

            var adapter = new SqlDataAdapter(commStr, conStr);

            adapter.Fill(universityDB);

            var users = universityDB.Tables[0];
            var oders = universityDB.Tables[1];

            var UsersOdersRel = new DataRelation("Users_Oders", users.Columns["id"],
                oders.Columns["User_id"], true);

            universityDB.Relations.Add(UsersOdersRel);

            Console.WriteLine("Primary Key: {0}", users.PrimaryKey.Length);
            Console.WriteLine("Key is unique: {0}", users.Columns["id"].Unique);
            Console.WriteLine("Allow DB null: {0}", users.Columns["id"].AllowDBNull);

            var childRow = users.Rows[1].GetChildRows("Users_Oders");

            foreach (var dataRow in childRow)
                Console.WriteLine(dataRow[0] + "|" + dataRow[1] + "|" + dataRow[2]);

            List<int> myList = new List<int>() { 1, 3, 45, 2, 2, 123, 7, 124, 124, 12, 4 };

            var a = from i in myList
                    where i % 2 == 0
                    select i;
            
            Console.WriteLine(B);
        }
        [Required]
        public static int B { get; set; }

        public static async void WriteMessage()
        {
            Console.WriteLine(await DoWorkAsync());
        }

        private static Task<string> DoWorkAsync()
        {
            Thread.Sleep(1000);
            return Task.Run(() => { return "Job done"; });
        }

    }

    [Serializable]
    class MyClass
    {


    }



}