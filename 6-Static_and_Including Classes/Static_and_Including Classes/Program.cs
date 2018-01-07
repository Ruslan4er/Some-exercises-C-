using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Including_Classes
{
    class Program
    {


        static void Main()
        {
            int[] _someArray = { 1, 2, 33, 4, 5, 23, 22, 66, 3, 234, 23 };

            Book.Notes note = new Book.Notes();
            Book book = new Book();

            book.Read();
            note.DoNote();

            _someArray.SortUp();

            foreach (var value in _someArray)
                Console.Write(value.ToString() + " ");
            

            // Delay.
            Console.ReadKey();
        }


    }
}
