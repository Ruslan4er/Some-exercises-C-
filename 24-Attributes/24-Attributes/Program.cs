using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Attributes
{
    enum AccessLevelControl
    {
        FullControl, MediumControl, LowControl
    }

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    sealed class AccessLevelAttribute : Attribute
    {
        private readonly AccessLevelControl _accessLevelControl;

        public AccessLevelAttribute(AccessLevelControl accessLevelControl)
        {
            _accessLevelControl = accessLevelControl;
        }

        public AccessLevelControl LevelControl { get => _accessLevelControl; }
    }

    class Employee { }

    [AccessLevel(AccessLevelControl.LowControl)]
    class Manager : Employee
    {

    }
    [AccessLevel(AccessLevelControl.MediumControl)]
    class Programmer : Employee
    {

    }
    [AccessLevel(AccessLevelControl.FullControl)]
    class Director : Employee
    {

    }


    class Program
    {
        static void ProtectedSection(Employee emp)
        {
            if (emp == null)
                throw new NullReferenceException();

            Type employee = emp.GetType();
            object[] attribute = employee.GetCustomAttributes(typeof(AccessLevelAttribute), false);

            if (attribute.Length == 0)
                return;

            foreach (AccessLevelAttribute item in attribute)
            {
                Console.WriteLine("Должность: {0, -12} уровень доступа: {1}", 
                    employee.Name, item.LevelControl);
            }
        }

        static void Main(string[] args)
        {
            var employee = new Employee[] { new Manager(), new Programmer(), new Director() };

            foreach (var emp in employee)
            {
                ProtectedSection(emp);
            }
            Console.ReadKey();
        }

    }
}
