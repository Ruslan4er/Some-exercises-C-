using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Page
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Text { get; set; }
    }

    class PageContext : DbContext
    {
       public DbSet<Page> Pages { get; set; }
    }
}
