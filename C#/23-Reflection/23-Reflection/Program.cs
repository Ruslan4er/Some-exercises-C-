using System;
using System.Reflection;

namespace _23_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.Load("TemperatureConverter");

            Console.WriteLine(assembly.FullName);
            Console.WriteLine(assembly.Location);


            dynamic instance = Activator.CreateInstance(assembly.GetType("TemperatureConverter.Converter"));

            Console.WriteLine(instance.Farhenheit(15)+"");

            Console.ReadKey();
        }
    }
}
