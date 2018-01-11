using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, IEnumerable<object>,IEnumerator<object>
    {
        private TKey[] KeyArray;
        private TValue[] ValueArray;
        private int count;
        private int position = -1;

       

        public MyDictionary()
        {
            KeyArray = new TKey[count];
            ValueArray = new TValue[count];
        }


        public int Count { get; }

        public void AddPair(TKey key, TValue value)
        {
            TKey[] keyArray = new TKey[KeyArray.Length + 1];
            TValue[] valueArray = new TValue[ValueArray.Length + 1];
            KeyArray.CopyTo(keyArray,0);
            ValueArray.CopyTo(valueArray, 0);
            keyArray[ValueArray.Length] = key;
            valueArray[ValueArray.Length] = value;
            KeyArray = keyArray;
            ValueArray = valueArray;


        }

        public string this[int key]
        {
            get
            {
                for (int i = 0; i < KeyArray.Length; i++)
                {
                    if (key >= 0 && key < KeyArray.Length)
                        return KeyArray[key] + " - " + ValueArray[key];
                }
                return "Такого элемента нет";
            }
        }


        public IEnumerator<object> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Dispose()
        {
            Reset();
        }

        public bool MoveNext()
        {
            while (true)
            {
                if (position< KeyArray.Length-1)
                {
                    position++;
                    return true;
                }
                return false;
            }
            
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get
            {
                return KeyArray[position] + " " + ValueArray[position];
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return KeyArray[position] + " " + ValueArray[position];
            }
        }
    }
}
