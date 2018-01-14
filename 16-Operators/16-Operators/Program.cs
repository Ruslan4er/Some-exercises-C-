using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Block block1 = new Block();
            Block block2 = new Block();
            Block block3 = new Block(11,22,11,22);

            Console.WriteLine("Блок 1 равен блоку 2? - {0}",block1.Equals(block2));
            Console.WriteLine("Блок 1 равен блоку 3? - {0}",block1.Equals(block3));

            Console.WriteLine(block1.ToString());
            Console.ReadKey();

        }
    }
}
