using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP_Project
{
    class Model
    {
        public int Add(int x1, int x2)
        {
            return x1 + x2;
        }

        public int Sub(int x1, int x2)
        {
            return x1 - x2;
        }

        public int Mult(int x1, int x2)
        {
            return x1 * x2;
        }

        public int Div(int x1, int x2)
        {
            if (x2 != 0)
            {
                return x1 / x2;
            }
            return 0;
        }


    }
}
