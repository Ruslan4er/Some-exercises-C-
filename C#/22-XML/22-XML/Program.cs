using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _22_XML
{
    class Program
    {
        static void Main(string[] args)
        {

            XmlTextWriter writer = new XmlTextWriter(@"MyXML.xml", null);

            writer.Formatting = Formatting.Indented;
            writer.IndentChar = '\t';
            writer.Indentation = 1;

            writer.WriteStartDocument();
            writer.WriteStartElement("MyContacts");
            writer.WriteStartElement("Contact");
            writer.WriteStartAttribute("Phone");
            writer.WriteValue("+37586854478");
            writer.WriteEndAttribute();
            writer.WriteValue("Andrew");
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.Close();


            FileStream fileStream = new FileStream(@"MyXML.xml", FileMode.Open);
            XmlTextReader reader = new XmlTextReader(fileStream);


            while (reader.Read())
            {
                if (reader.NodeType != XmlNodeType.Whitespace)
                {
                    Console.WriteLine("NodeType: {0,-15}| Name: {1,-15}| Value: {2,-15}",
                        reader.NodeType,
                        reader.Name,
                        reader.Value);
                }
            }

            Console.ReadKey();


        }
    }
}
