using System;

namespace _15_Exceptions
{
    struct Worker
    {

        private int beginYear;
        private int currentYear;


        public string WorkerName { get; }
        public string WorkerPosition { get; }

        public int BeginYear
        {
            get
            {
                return beginYear;
            }
            set
            {
                if (value <= currentYear && value >= currentYear - 60)
                    beginYear = value;
                else
                {
                    Console.WriteLine("Неверный формат даты, введите снова");
                    BeginYear = int.Parse(Console.ReadLine());
                }
            }
        }


        public Worker(string workerName, string workerPosition, int year)
        {
            WorkerName = workerName;
            WorkerPosition = workerPosition;
            currentYear = DateTime.Now.Year;
            beginYear = DateTime.Now.Year;
            BeginYear = year;
        }
    }
}