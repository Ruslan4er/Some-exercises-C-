using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Including_Classes
{
    public class Book
    {
        public class Notes
        {
            public void DoNote()
            {
                Console.WriteLine("Some note in book");
                
            }
            
        }

        public void Read()
        {
            Console.WriteLine("Book was readed");
        }

    }
}
