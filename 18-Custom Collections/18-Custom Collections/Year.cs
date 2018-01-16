using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Custom_Collections
{
    class Year : IEnumerable, IEnumerator
    {
        private string[] months = {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
        };
        private int[] monthDay = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        private int position = -1;

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (position < months.Length-1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        public object Current
        {
            get { return months[position]; }
        }

        public string this[int index]
        {
            get
            {
                if (index > 0 && index < 12)
                {
                    return months[index - 1];
                }
                return "Неверный номер месяца";
            }
        }

        public string[] FindMonth(int dayCount)
        {
            string[] result = new string[0];
            for (int i = 0; i < monthDay.Length; i++)
            {
                if (dayCount == monthDay[i])
                {
                    string[] x = new string[result.Length + 1];
                    result.CopyTo(x,0);
                    x[result.Length] = months[i];
                    result = x;
                }
            }
            return result;
        }

        
    }
}
