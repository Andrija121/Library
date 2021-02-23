using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookInfo
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }

        public string GetInfo()
        {
            return Name + " - " + Author + " - " + Year;
        }
       /* public Book GetBookName(string name)
        {
            List<Book> books = new List<Book>();
            foreach (var book in books)
            {
                if ()
                {

                }
            }

        }
       */
    }
}
