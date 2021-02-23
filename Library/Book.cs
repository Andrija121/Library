using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
        private List<BookInfo> books;
        public Book()
        {
            this.books = new List<BookInfo>();
        }

        public void AddBook(string name,string author,int year)
        {
            BookInfo bookInfo = new BookInfo();
            bookInfo.Name = name;
            bookInfo.Author = author;
            bookInfo.Year = year.ToString();

            books.Add(bookInfo);
        }
        public List<BookInfo> GetBookInfos()
        {
            return books;
        }

    }
}
