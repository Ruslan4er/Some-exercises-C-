using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _25_Serialization
{
    [XmlRoot("MyClass")]
    public class Employee
    {
        private string _name;
        private int _age;
        private string _status;

        [XmlAttribute("Name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }

    [Serializable]
    public class Employee1
    {
        private string _name;
        private int _age;
        private string _status;

        [XmlAttribute("Name")]
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {   //XML Сериализация
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));

            Employee employee = new Employee();
            employee.Age = 22;
            employee.Name = "Ivan";
            employee.Status = "Married";

            FileStream xmlStream = new FileStream("MyData.xml", FileMode.Create);
            serializer.Serialize(xmlStream, employee);
            xmlStream.Close();

            //Binary Сериализация
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream bineryStream = new FileStream("MyData.dat", FileMode.Create);

            Employee1 employee1 = new Employee1();
            employee1.Age = 42;
            employee1.Name = "Maria";
            employee1.Status = "Married";

            formatter.Serialize(bineryStream, employee1);
            bineryStream.Close();

            //XML Десериализация
            FileStream xmlStreamReader = new FileStream("MyData.xml", FileMode.Open);
            Employee instance = serializer.Deserialize(xmlStreamReader) as Employee;

            if (instance != null)
            {
                Console.WriteLine(new string('_', 25));
                Console.WriteLine("1-{0}\n2-{1}\n3-{2}", instance.Age, instance.Name, instance.Status);
            }

            xmlStreamReader.Close();

            //binary Десериализация
            FileStream binStream = new FileStream("MyData.dat", FileMode.Open);

            Employee1 inst = formatter.Deserialize(binStream) as Employee1;

            Console.WriteLine(new string('_', 25));
            Console.WriteLine("1-{0}\n2-{1}\n3-{2}", inst.Age, inst.Name, inst.Status);
            binStream.Close();

            Console.ReadKey();
        }
    }
}
