using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    abstract class Citizen
    {
        private int age;
        private string name;
        private int id;

        protected Citizen(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public int Age
        {
            get { return age; }
        }

        public string Name
        {
            get { return name; }
        }

        public int Id
        {
            get { return id; }
        }

        public abstract void Talk();

        public static bool operator == (Citizen c1, Citizen c2)
        {
            if (ReferenceEquals(c1,c2))
            {
                return true;
            }
            if ((object)c1 == null || (object) c2==null)
            {
                return false;
            }

            return c1.Id==c2.Id;
        }

        public static bool operator !=(Citizen c1, Citizen c2)
        {
            return !(c1 == c2);
        }
    }
}
