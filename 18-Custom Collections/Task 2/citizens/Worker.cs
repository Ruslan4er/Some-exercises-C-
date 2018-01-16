using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Worker:Citizen    
    {
        public override void Talk()
        {
            Console.WriteLine("I'm worker");
        }

        public void Work()
        {
            Console.WriteLine("i'm working");
        }

        public Worker(int id, string name, int age) : base(id, name, age)
        {
        }
    }
}
