using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Pensioner : Citizen
    {
        private int accumulation = 23;

        public int Accumulation
        {
            get { return accumulation; }
        }

        
        public override void Talk()
        {
            Console.WriteLine("I'm pensioner");
        }

        public void GetPension()
        {
            accumulation += 2223;
        }

        public Pensioner(int id, string name, int age) : base(id, name, age)
        {
        }
    }
}
