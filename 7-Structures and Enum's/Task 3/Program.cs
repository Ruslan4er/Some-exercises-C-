using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _7_Structures_and_Enum_s;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 3
            MyClass myClass = new MyClass();
            MyStruct myStruct = new MyStruct();

            myClass.change = "not changed";
            myStruct.change = "not changed";
            ClassTaker(myClass);
            StructTaker(myStruct);
            //StructTaker(ref myStruct);
            Console.WriteLine("Значение в классе - {0}", myClass.change);
            Console.WriteLine("Значение в структуре- {0}", myStruct.change);

            //StaticClass.Print();
            var colr = Enum.GetName(typeof(Colors), 0);
        }


        //Task 3
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "changed";
        }

        //Task 3
        //static void StructTaker(ref MyStruct myStruct)
        static void StructTaker(MyStruct myStruct)
        {
            myStruct.change = "changed";
        }



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


    }
}
