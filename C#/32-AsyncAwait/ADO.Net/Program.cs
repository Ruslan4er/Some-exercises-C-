using System;
using System.Configuration;

namespace ADO.Net
{
    class Program
    {

        static void Main(string[] args)
        {
            var settings = new ConnectionStringSettings
            {
                Name = "MyConnectionString1",
                ConnectionString = @"Data Source =.\SQLEXPRESS;
                                     Initial Catalog =ShopDB;
                                     Integration Security = true;"
            };

            //var connectionStringBuilder = new SqlConnectionStringBuilder();
            //connectionStringBuilder.DataSource = @".\SQLEXPRESS";
            //connectionStringBuilder.InitialCatalog = "ShopDB";
            //connectionStringBuilder.IntegratedSecurity = true;
            //connectionStringBuilder.Pooling = false;

            Configuration config;
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.ConnectionStrings.ConnectionStrings.Add(settings);
            config.Save();

            ConnectionStringsSection section = config.GetSection("connectionStrings") as ConnectionStringsSection; ;
            Console.WriteLine("Записано");
            if (!section.SectionInformation.IsProtected)
            {
                section.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
            }
            config.SaveAs("asdsa.txt");
            Console.WriteLine(ConfigurationManager.ConnectionStrings["MyConnectionString1"].ConnectionString);
        }
    }
}
