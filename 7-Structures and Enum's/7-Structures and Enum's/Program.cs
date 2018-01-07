using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Structures_and_Enum_s
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            //Notebook nb = new Notebook("Pavilion", "HP", 2332);
            //nb.ShowNotebook();
            //Console.ReadKey();

            // Task 2

            //Train[] trainArray = new Train[5];

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("Введите данный о новом поезде");
            //    Console.WriteLine("Точка отправления:");
            //    string startPoint = Console.ReadLine();
            //    Console.WriteLine("Номер поезда");
            //    int trainNumber = Int32.Parse(Console.ReadLine());
            //    Console.WriteLine("Время отправления");
            //    int time = Int32.Parse(Console.ReadLine()); ;

            //    trainArray[i] = new Train(startPoint, trainNumber, time);
            //}
            //Console.WriteLine("Введите номер поезда, который хотите найти");
            //int number = Int32.Parse(Console.ReadLine());

            //foreach (var train in trainArray)
            //{
            //    bool ok = false;
            //    if (train.TrainNumber == number)
            //    {
            //        Console.WriteLine("Поезд номер: {0} отправляется от {1} в {2}",
            //            train.TrainNumber, train.StartPoint, train.Time);
            //        ok = true;
            //    }
            //    if (!ok)
            //        Console.WriteLine("Поезд не найден");       
            //}

            //Task 3
            //MyClass myClass = new MyClass();
            //MyStruct myStruct = new MyStruct();

            //myClass.change = "not changed";
            //myStruct.change = "not changed";
            //ClassTaker(myClass);
            //StructTaker(myStruct);
            ////StructTaker(ref myStruct);
            //Console.WriteLine("Значение в классе - {0}",myClass.change);
            //Console.WriteLine("Значение в структуре- {0}", myStruct.change);

            //StaticClass.Print();
            //var colr = Enum.GetName(typeof(Colors), 0);

            // Task 4
            //int color= 0;
            //bool ok= true;
            //Console.WriteLine("Выберите цвет: Black, Blue, Red");
            //var colr = Console.ReadLine();

            //if (colr == Enum.GetName(typeof(Colors), 0))
            //    color = 0;
            //else if (colr == Enum.GetName(typeof(Colors), 1))
            //    color = 1;
            //else if (colr == Enum.GetName(typeof(Colors), 2))
            //    color = 2;
            //else
            //{
            //    Console.WriteLine("Цвет не найден");
            //    ok = false;
            //}

            //if (ok)
            //    StaticClass.Print("Hello world", color);
            


            


            Console.ReadKey();
        }






        //Task 3
        //static void ClassTaker(MyClass myClass)
        //{
        //    myClass.change = "changed";
        //}

        //Task 3
        //static void StructTaker(ref MyStruct myStruct)
        //static void StructTaker(MyStruct myStruct)
        //{
        //    myStruct.change = "changed";
        //}
    }
}
