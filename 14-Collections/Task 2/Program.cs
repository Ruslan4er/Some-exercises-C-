using System;
using System.Collections;
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
            int[] myArray = new[] {1, 2, 4, 2, 1, 512, 125, 12, 7, 2, 3, 524, 21, 2, 4, 6, 11, 22, 5, 7, 4, 22, 77};

            MyCollection myCollection = new MyCollection();

            foreach (var value in myCollection.FindEvens(myArray))
            {
                Console.WriteLine(value);
            }

            //IEnumerable enumerable = myCollection.FindEvens(myArray);

            //IEnumerator enumerator = enumerable.GetEnumerator();

            

            Console.ReadKey();
        }
    }
}
