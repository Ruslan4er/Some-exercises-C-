using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream xmlStream = new FileStream("TelephoneBook.xml", FileMode.OpenOrCreate);
            XmlTextReader xmlReader = new XmlTextReader(xmlStream);

            while (xmlReader.Read())
            {
                if (!xmlReader.HasAttributes) continue;
                if (xmlReader.Name.Equals("Contact"))
                    Console.WriteLine("<{0}>", xmlReader.GetAttribute("TelephoneNumber"));
            }
            xmlReader.Close();

            Console.ReadKey();
        }
    }
}
