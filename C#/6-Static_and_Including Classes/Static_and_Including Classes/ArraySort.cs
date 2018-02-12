using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_and_Including_Classes
{
    static class ArraySort
    {


        public static void SortUp(this int[] _someArray)
        {
            for (int i = 0; i < _someArray.Length; i++)
            {
                for (int j = _someArray.Length - 1; j > i; j--)
                {
                    if (_someArray[i] > _someArray[j])
                    {
                        int x = _someArray[j];
                        _someArray[j] = _someArray[i];
                        _someArray[i] = x;
                    }

                }
            }
        }

    }
}
