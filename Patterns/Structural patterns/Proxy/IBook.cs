using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    interface IBook : IDisposable
    {
        Page GetPage(int number);
    }


    class BookStore : IBook
    {
        private PageContext db;

        public BookStore()
        {
            db = new PageContext();
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public Page GetPage(int number)
        {
            return db.Pages.FirstOrDefault(p => p.Number == number);
        }
    }


    class BookStoreProxy : IBook
    {
        private List<Page> pages;
        private BookStore bookStore;

        public BookStoreProxy()
        {
            pages = new List<Page>();
        }

        public void Dispose()
        {
            bookStore?.Dispose();
        }

        public Page GetPage(int number)
        {
            Page page = pages.FirstOrDefault(p => p.Number == number);
            if (page == null)
            {
                if (bookStore == null)
                    bookStore = new BookStore();

                page = bookStore.GetPage(number);
                pages.Add(page);
            }
            return page;
        }
    }
}
