using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public abstract class Programmer
    {
        public ILanguage Language { get; set; }

        protected Programmer(ILanguage language)
        {
            Language = language;
        }

        public void DoWork()
        {
            Language.Build();
            Language.Execute();
        }

        public abstract void EarnMoney();
    }

    public class FreelanceProgrammer : Programmer
    {
        public FreelanceProgrammer(ILanguage language) : base(language)
        {
        }

        public override void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }

    class CorporateProgrammer : Programmer
    {
        public CorporateProgrammer(ILanguage lang)
            : base(lang)
        {
        }
        public override void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");
        }
    }
}
