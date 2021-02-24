using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Book
    {
    
    
        public string Name { get; set; }
        public string Author { get; set; }
        public string Year { get; set; }


        public Book(string name, string author, int year)
        {
           
            this.Name = name;
            this.Author = author;
            this.Year = year.ToString();
        }
        
        public string GetInfo()
        {
            return Name + " - " + Author + " - " + Year;
        }

    }
}
