using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class BookManagement
    {
        List<Book> books;

        List<string> landedBooks;


        public BookManagement()
        {
            books = new List<Book>();
            landedBooks = new List<string>();
        }
        public List<string> GetBooksInfo()
        {
            List<string> booksInfo = new List<string>();
            foreach (var book in books)
            {
                booksInfo.Add(book.GetInfo());
            }
            return booksInfo;
        }
        public bool AddBook(Book book)
        {
            foreach (var b in books)
            {
                if(book.Name==b.Name)
                {
                    return false;
                } 
            }
            books.Add(book);
            return true;
            
        }
        public void AddRegisteredBook(string bookInfo,string userName)
        {
            int rentedBookIndex=0;
            for (int i = 0; i < books.Count(); i++)
            {
                if (books[i].GetInfo()==bookInfo)
                {
                    rentedBookIndex = i;
                    break;
                }
            }
            books.RemoveAt(rentedBookIndex);
            string books1 = userName + " / " + bookInfo;
            landedBooks.Add(books1);
            
        }
        public List<string> GetRegisteredBook()
        {
            return landedBooks;
        }
        public void ReturnBook(string landedBookInfo)
        {
            //Ta knjiga lbi koju dobijem treba da izbrisem iz landed book kolekcije,
            // U stringu koji dobijem treba da izvucem autora, naziv knjige, i godinu
            // Te vrednosti treba da iskoristim da pozovem addBook metodu
            // Na form opet da refresujem listboxove(1,3)
            //manipulacija stringova
        }

    }
}
