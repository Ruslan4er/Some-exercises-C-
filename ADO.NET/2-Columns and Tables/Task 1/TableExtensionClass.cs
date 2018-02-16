using System;
using System.Data;
using System.Data.SqlClient;

namespace Task_1
{
    public static class TableExtensionClass
    {
        public static void LoadWithSchema(this DataTable table, SqlDataReader reader)
        {
            table.CreateSchemaFromReader(reader);
            table.Load(reader);
        }

        private static void CreateSchemaFromReader(this DataTable table, SqlDataReader reader)
        {
            DataTable schemaTable = reader.GetSchemaTable();

            foreach (DataRow schemaRow in schemaTable.Rows)
            {
                DataColumn column = new DataColumn((string)schemaRow["ColumnName"]);
                column.AllowDBNull = (bool)schemaRow["AllowDbNull"];
                column.DataType = (Type)schemaRow["DataType"];
                column.Unique = (bool)schemaRow["IsUnique"];
                column.ReadOnly = (bool)schemaRow["IsReadOnly"];
                column.AutoIncrement = (bool)schemaRow["IsIdentity"];

                if (column.DataType == typeof(string))
                    column.MaxLength = (int)schemaRow["ColumnSize"];

                if (column.AutoIncrement = true)
                {
                    column.AutoIncrementStep = -1;
                    column.AutoIncrementSeed = 0;
                }

                table.Columns.Add();
            }
        }

    }
}