using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Generics
{
    class MyList<T>:IList<T>
    {
        private T[] valueList;
        private int[] indexersList;
        private int n = 0;

        public int Count { get; }

        public MyList(int count)
        {
            valueList = new T[count];
            this.Count = count;
        }

        public void AddItem(T item)
        {
            if (n!= Count)
            {
                valueList[n] = item;
                n++;
            }
            else
                Console.WriteLine("Массив полон");
        }

        public T this[int index]
        {
            get {
                if (index>Count)
                {
                    Console.WriteLine("Такого элемента нет");
                }
                return valueList[index]; }
            set { valueList[index] = value; }
        }


        

    }
}
