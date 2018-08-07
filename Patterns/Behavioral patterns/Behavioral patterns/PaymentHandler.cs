using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behavioral_patterns
{
    abstract class PaymentHandler
    {
        public PaymentHandler Succesor { get; set; }
        public abstract void Handle(Receiver receiver);
    }

    class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer)
                Console.WriteLine("Выполняем банковский перевод");
            else if (Succesor != null)
            {
                Succesor.Handle(receiver);
            }
        }
    }

    class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer)
                Console.WriteLine("Выполняем денежные переводы");

            else if (Succesor != null)
            {
                Succesor.Handle(receiver);
            }
        }
    }

    class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer)
                Console.WriteLine("Выполняем переводы PayPal");

            else if (Succesor != null)
            {
                Succesor.Handle(receiver);
            }
        }
    }
}
