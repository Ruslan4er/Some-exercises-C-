using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27_Nonvirtual_interface
{
    class BaseClass
    {
        public virtual void DoMethods()
        {
            ShowSomething();
            DoSomeThing();
        }

        protected virtual void ShowSomething()
        {
            Console.WriteLine("Метод из базовой комплектации 1");
        }

        protected virtual void DoSomeThing()
        {
            Console.WriteLine("Метод из базовой комплектации 2");
        }
    }

    class MediumClass : BaseClass
    {
        protected override void DoSomeThing()
        {
            Console.WriteLine("Метод из стандартной комплектации 1");
        }

        protected override void ShowSomething()
        {
            Console.WriteLine("Метод из стандартной комплектации 2");
        }
    }

    class ProClass : MediumClass
    {
        public override void DoMethods()
        {
            DoSomeThing();
            ShowSomething();
            SomeMethod();
        }
        
        protected override void ShowSomething()
        {
            Console.WriteLine("Метод из PRO комплектации 2");
        }

        protected void SomeMethod()
        {
            Console.WriteLine("Дополнительный PRO метод");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BaseClass[] classArray = { new BaseClass(), new MediumClass(), new ProClass(), };

            foreach (var @class in classArray)
            {
                @class.DoMethods();
                Console.WriteLine(new string('_', 25));
            }

            Console.ReadKey();
        }
    }
}
