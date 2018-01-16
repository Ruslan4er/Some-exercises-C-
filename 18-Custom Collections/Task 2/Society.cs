using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Society : IEnumerable
    {
        private Citizen[] citizens = new Citizen[0];

        private int position = -1;
        private int pensionerCount;

        public IEnumerator GetEnumerator()
        {
            return citizens.GetEnumerator();
        }

        public int Count
        {
            get { return citizens.Length; }
        }

        public bool Contains(Citizen newCitizen, out int index)
        {
            for (int i = 0; i < citizens.Length; i++)
            {
                if (citizens[i] == newCitizen)
                {
                    index = i;
                    return true;
                }
            }
            index = -1;
            return false;
        }

        public int Add(Citizen citizen)
        {
            if (Contains(citizen, out var index))
            {
                Console.WriteLine("Гражданин с таким id уже есть");
                return index;
            }

            var newCitizens = new Citizen[citizens.Length + 1];
            if (citizen is Pensioner)
            {
                Array.ConstrainedCopy(citizens, 0, newCitizens, 0, pensionerCount); // Копирование элементов из старого массива до позиции вставляемого элемента
                newCitizens[pensionerCount] = citizen; // Вставка нового элемента на необходимую позицию
                // Копирование оставшихся элементов из старого массива
                Array.ConstrainedCopy(citizens, pensionerCount, newCitizens, pensionerCount + 1,
                    citizens.Length - pensionerCount);

                pensionerCount++;
                return pensionerCount - 1;

            }
            citizens.CopyTo(newCitizens, 0);
            newCitizens[citizens.Length] = citizen;
            citizens = newCitizens;

            return position;
        }

        public void Clear()
        {
            citizens = new Citizen[0];
        }

        public int IndexOf(Citizen value)
        {
            for (int i = 0; i < Count; i++)
                if (citizens[i] == value)
                    return i;
            return -1;
        }

        public void Remove()
        {
            var newCitizens = new Citizen[citizens.Length - 1];
            Array.ConstrainedCopy(citizens, 1, newCitizens, 0, newCitizens.Length);
            citizens = newCitizens;
        }

        public void Remove(Citizen citizen)
        {
            int index;
            if (Contains(citizen, out index))
            {
                var newCitizens = new Citizen[citizens.Length - 1];
                Array.ConstrainedCopy(citizens, 0, newCitizens, 0, index);
                Array.ConstrainedCopy(citizens, index + 1, newCitizens, index, newCitizens.Length - index);
                citizens = newCitizens;
            }
        }

        public Citizen ReturnLast(out int index)
        {
            index = citizens.Length + 1;
            return citizens[citizens.Length-1];
        }
    }
}
