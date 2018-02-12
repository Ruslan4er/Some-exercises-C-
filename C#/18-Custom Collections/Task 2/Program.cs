using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Society society = new Society();
            int index;

            Console.WriteLine("Добавление элементов в коллекцию");
            society.Add(new Student(2212,"Alex",22));
            society.Add(new Pensioner(223, "Michael", 62));
            society.Add(new Worker(11123, "Jhon", 32));
            society.Add(new Pensioner(223, "Rita", 60)); // Добавления не произойдет, т.к. уже есть элемент с таким номером паспорта
            society.Add(new Pensioner(2123121, "Sam", 87));

            foreach (Citizen item in society)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(new string('*', 30));

            Pensioner p4 = new Pensioner(223, "Rita", 60); // В коллекцию не добавляем
            Console.WriteLine("В коллекции есть {0} - {1}, его позиция {2} ", p4.Name, society.Contains(p4, out index), index);
            Console.WriteLine(new string('*', 30));

            Console.WriteLine("Кто последний? - {0}, позиция {1}", society.ReturnLast(out index).Name, index);
            Console.WriteLine(new string('*', 30));

            Console.WriteLine("Удаление элементов из коллекции");
            society.Remove(p4);
            society.Remove();
            foreach (Citizen item in society)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(new string('*', 30));

            society.Clear();
            if (society.Count == 0)
            {
                Console.WriteLine("Коллекция очищена");
            }

            Console.ReadKey();
        }
    }
}
