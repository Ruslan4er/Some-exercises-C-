using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Generics
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива");
            int length = int.Parse(Console.ReadLine());

            MyList<int> myList = new MyList<int>(length);

            for (int i = 0; i < length; i++)
                myList.AddItem(rnd.Next(0, 20));
            
            Console.WriteLine("Элемент с каким номером найти?");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine("Элемент номер {0} равен {1}", index, myList[index]);

            Console.WriteLine("Общее количество элементов: {0}", myList.Count);
            
            // Task 3 Использование расширяющих методов
            Console.WriteLine("Массив элементов:");
            int[] newArr= myList.GetArray();
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.Write(newArr[i]+" ");
            }

            Console.ReadKey();
        }
       
    }
}
