using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    [Serializable]
    class Book
    {

        public string Title { get; set; }

        public string Author { get; set; }

        public int Price { get; set; }

        public int Amount { get; set; }

        public Book(string title, string author, int Price, int amount)
        {
            this.Title = title;
            this.Author = author;
            this.Price = Price;
            this.Amount = amount;
        }

    }
}
