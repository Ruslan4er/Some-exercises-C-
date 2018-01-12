using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Exceptions
{
    class Factory
    {
        private Worker[] workers;

        public Factory()
        {
            workers = CreateWorkersArray(5);
        }

        public Factory(int workersCount)
        {
            workers = CreateWorkersArray(workersCount);
        }


        private Worker[] CreateWorkersArray(int count)
        {
            Worker[] _workers = new Worker[count];

            for (int i = 0; i < _workers.Length; i++)
            {
                Console.WriteLine("Введите имя работника");
                string name = Console.ReadLine();

                Console.WriteLine("Введите должность");
                string position = Console.ReadLine();

                Console.WriteLine("Введите год начала работы");
                string tmp = Console.ReadLine();
                int year;
                try
                {
                     year = int.Parse(tmp) ;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Неверный формат даты");
                    Console.WriteLine(e);
                    year = DateTime.Now.Year;
                }

                _workers[i] = new Worker(name, position, year);
            }

            return _workers;

        }


        public string this[int index]
        {
            get
            {
                bool answer = false;
                foreach (var worker in workers)
                {
                    
                    if (DateTime.Now.Year-worker.BeginYear> index)
                    {
                        return worker.WorkerName+"\n";
                        answer =true;
                    }
                }
                if (!answer)
                    return "Таких работников нет";
                return "";
            }

        }

    }
}
