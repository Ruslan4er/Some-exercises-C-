using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Dictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private TKey[] KeyArray;
        private TValue[] ValueArray;
        private int count;
        public int Count { get; }

        public Dictionary(int count)
        {
            KeyArray = new TKey[count];
            ValueArray = new TValue[count];
            Count = count;
        }


        public void AddPair(TKey key, TValue value)
        {
            if (count!=Count)
            {
                KeyArray[count] = key;
                ValueArray[count] = value;
                count++;
            }
            else
            {
                Console.WriteLine("Массив заполнен");
            }
            
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

        



    }
}
