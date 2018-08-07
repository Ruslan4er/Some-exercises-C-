using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver(false, true, true);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHandler = new MoneyPaymentHandler();
            PaymentHandler payPalPaymentHandler = new PayPalPaymentHandler();

            bankPaymentHandler.Succesor = payPalPaymentHandler;
            payPalPaymentHandler.Succesor = moneyPaymentHandler;

            bankPaymentHandler.Handle(receiver);

            Console.ReadKey();

        }
    }
}
