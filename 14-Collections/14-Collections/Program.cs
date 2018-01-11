using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Collections
{
    public delegate void SomeDelegate();


    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            myList.AddItem(12);
            myList.AddItem(122);
            myList.AddItem(1122);
            int[] arr = myList.GetArray();

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("________________");
            Console.WriteLine(myList[1]);

            Console.WriteLine("________________");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }

            

            Console.ReadKey();

        }
    }

    public static class MyClass
    {
        public static T[] GetArray<T>(this IEnumerable<T> list)
        {
            T[] result = new T[list.Count()];
            int i = 0;

            foreach (T value in list)
            {
                result[i] =value;
                i++;
            }

            return result;
        }
    }

}
