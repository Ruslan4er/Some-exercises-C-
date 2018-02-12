using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7_Structures_and_Enum_s;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 2

            Train[] trainArray = new Train[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите данный о новом поезде");
                Console.WriteLine("Точка отправления:");
                string startPoint = Console.ReadLine();
                Console.WriteLine("Номер поезда");
                int trainNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Время отправления");
                int time = Int32.Parse(Console.ReadLine()); ;

                trainArray[i] = new Train(startPoint, trainNumber, time);
            }
            Console.WriteLine("Введите номер поезда, который хотите найти");
            int number = Int32.Parse(Console.ReadLine());

            foreach (var train in trainArray)
            {
                bool ok = false;
                if (train.TrainNumber == number)
                {
                    Console.WriteLine("Поезд номер: {0} отправляется от {1} в {2}",
                        train.TrainNumber, train.StartPoint, train.Time);
                    ok = true;
                }
                if (!ok)
                    Console.WriteLine("Поезд не найден");
            }

            Console.ReadKey();
        }
    }
}
