using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _14_Collections
{
    public interface IMyList<T>
    {
        void AddItem(T itam);
        T this[int index] { get; }
        int Count { get; }


    }

    class MyList<T> : IMyList<T>, IEnumerable<T>
    {
        private T[] valueList;
        private int[] indexersList;
        private int n;
        private int position = -1;

        public MyList()
        {
            valueList = new T[0];
        }

        public int Count { get; }

        public MyList(int count)
        {
            valueList = new T[count];
            this.Count = count;
        }

        public void AddItem(T item)
        {
            T[] tArray = new T[valueList.Length + 1];
            valueList.CopyTo(tArray, 0);
            tArray[valueList.Length] = item;
            valueList = tArray;
        }

        public T this[int index]
        {
            get
            {
                return valueList[index];
            }
            set { valueList[index] = value; }
        }


        public IEnumerator<T> GetEnumerator()
        {
            while (true)
            {
                if (position < valueList.Length - 1)
                {
                    position++;
                    yield return valueList[position];
                }
                else
                    yield break;

            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
