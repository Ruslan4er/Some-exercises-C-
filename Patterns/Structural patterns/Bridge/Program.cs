using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Programmer freelancer = new FreelanceProgrammer(new CppLanguage());
            freelancer.DoWork();
            freelancer.EarnMoney();

            freelancer.Language = new CSharpLanguage();
            freelancer.DoWork();
            freelancer.EarnMoney();

            Console.ReadKey();
        }
    }
}
