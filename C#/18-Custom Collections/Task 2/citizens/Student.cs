using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Student :Citizen
    {
        public override void Talk()
        {
            Console.WriteLine("I'm student");
        }

        public void Study()
        {
            Console.WriteLine("I'm study now");
        }

        public Student(int id, string name, int age) : base(id, name, age)
        {
        }
    }
}
