using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MyCollection
    {
        public IEnumerable FindEvens(int[] array)
        {
            foreach (int element in array)
            {
                if (element % 2 == 0)
                    yield return element;
            }
        }
    }
}
