using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class Purchase
    {
        public int Id { get; set; }

        public string Person { get; set; }

        public string Adress { get; set; }

        public int BookId { get; set; }

        public DateTime Date { get; set; }
    }
}