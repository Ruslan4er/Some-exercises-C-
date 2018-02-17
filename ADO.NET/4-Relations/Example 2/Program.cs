using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var shopDB = CreateDataSetFromDB();

        }


        private static DataSet CreateDataSetFromDB()
        {
            var conStr = @"Data Source=.\SQLEXPRESS; Initial Catalog=ShopDB; Integrated Security=True";
            var comStr = "SELECT * FROM Customers;" +
                         "SELECT * FROM Orders;" +
                         "SELECT * FROM OrderDetails;" +
                         "SELECT * FROM Products";

            var shopDB = new DataSet("ShopDB");

            var adapter = new SqlDataAdapter(comStr, conStr) { MissingSchemaAction = MissingSchemaAction.AddWithKey };

            adapter.TableMappings.Add("Table", "Customers");
            adapter.TableMappings.Add("Table1", "Orders");
            adapter.TableMappings.Add("Table2", "OrderDetails");
            adapter.TableMappings.Add("Table3", "Products");

            adapter.Fill(shopDB);

            var customers = shopDB.Tables["Customers"];
            var orders = shopDB.Tables["Orders"];
            var orderDetails = shopDB.Tables["OrderDetails"];
            var products = shopDB.Tables["Products"];

            shopDB.Relations.Add("Orders_OrderDetails", orders.Columns["OrderID"], orderDetails.Columns["OrderID"]);
            shopDB.Relations.Add("Customers_Orders", customers.Columns["CustomerNo"], orders.Columns["CustomerNo"]);
            shopDB.Relations.Add("OrderDetails_Products", products.Columns["ProdID"], orderDetails.Columns["ProdID"]);

            return shopDB;
        }

    }
}
