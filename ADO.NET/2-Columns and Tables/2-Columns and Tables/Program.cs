using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Columns_and_Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            string conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=university; Integrated Security=True";
            SqlConnection connection = new SqlConnection(conStr);
            SqlCommand selectUsersCommand = new SqlCommand("SELECT * FROM Users", connection);
            connection.Open();
            var reader = selectUsersCommand.ExecuteReader();
            var table = CreateSchemeFromReader(reader, "Users");
            WriteDataFromReader(table, reader);


            foreach (DataColumn column in table.Columns)
            {
                Console.WriteLine("{0} - {1}", column.ColumnName, column.DataType);
            }


            foreach (DataRow row in table.Rows)
            {
                foreach (DataColumn column in table.Columns)
                    Console.WriteLine("{0}:{1}",column.ColumnName,row[column]);
                Console.WriteLine(new string('-',30));
            }

        }



        private static void WriteDataFromReader(DataTable table, SqlDataReader reader)
        {
            while (reader.Read())
            {
                DataRow row = table.NewRow();

                for (int i = 0; i < reader.FieldCount; i++)
                    row[i] = reader[i];

                table.Rows.Add(row);
            }
        }

        private static DataTable CreateSchemeFromReader(SqlDataReader reader, string tableName)
        {
            DataTable table = new DataTable(tableName);

            for (int i = 0; i < reader.FieldCount; i++)
                table.Columns.Add(new DataColumn(reader.GetName(i), reader.GetFieldType(i)));

            return table;
        }
    }
}
