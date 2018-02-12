using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Generics_part_2_
{
    class CarCollection<T> :MyList<T>, ICarColletion
    {
        private MyList<string> carNameList;
        private MyList<DateTime> carYearList;

        public CarCollection()
        {
            carNameList = new MyList<string>();
            carYearList = new MyList<DateTime>();
        }

        public void AddCar(string carName, DateTime carAge)
        {
            carNameList.Add(carName);
            carYearList.Add(carAge);
        }

        public string this[int index]
        {
            get
            {
                return carNameList[index]+"-"+carYearList[index].Year;
            }
        }

        public int Count
        {
            get { return carNameList.Count; }
        }

        public void ClearCars()
        {
            carNameList.Clear();
            carYearList.Clear();
        }







    }
}
