using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structural_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            // путешественник
            var driver = new Driver();
            // машина
            Auto auto = new Auto();
            // отправляемся в путешествие
            driver.Travel(auto);
            // встретились пески, надо использовать верблюда
            Camel camel = new Camel();
            // используем адаптер
            ITransport camelTransport = new CamelToTransportAdapter(camel);
            // продолжаем путь по пескам пустыни
            driver.Travel(camelTransport);

            Console.Read();
        }
    }
}
