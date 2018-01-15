using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_LINQ
{
    class Customer
    {
        private string _model;
        private string _customerName;
        private string _phoneNumber;

        public Customer()
        {
            Model = "X5";
            CustomerName = "Ivan Sidorov";
            PhoneNumber = "+375334562311";
        }

        public Customer(string model, string customerName, string phoneNumber)
        {
            Model = model;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }
    }
}
