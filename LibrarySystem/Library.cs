using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{

    [Serializable]
    class Library
    {

        private List<Book> Books; // Books list

        private List<Reader> Readers; // Readers list

        public Library() // Constuctor
        {
            this.Books = new List<Book>();
            this.Readers = new List<Reader>();
        }

        // Books part start

        public void AddBook(Book book)
        {
            this.Books.Add(book);
        }

        public void RemoveBook(int index)
        {
            this.Books.RemoveAt(index);
        }

        public void ShowBooks()
        {
            foreach (Book book in this.Books)
            {
                string Data = string.Format("\n\nId: {0}\n\nTitle: {1}\n\nAuthor: {2}\n\nPrice: {3}\n\nAmount: {4}\n\n", this.Books.IndexOf(book), book.Title, book.Author, book.Price, book.Amount);

                Console.WriteLine(Data);
            }
        }

        public void SearchBooksByTitle(string Title)
        {
            
            foreach (Book book in this.Books)
            {
                if (book.Title == Title)
                {
                    string Data = string.Format("\n\nId: {0}\n\nTitle: {1}\n\nAuthor: {2}\n\nPrice: {3}\n\nAmount: {4}\n\n", this.Books.IndexOf(book), book.Title, book.Author, book.Price, book.Amount);

                    Console.WriteLine(Data);
                }
            }

        }

        public void SearchBooksByAuthor(string Author)
        {
            foreach (Book book in this.Books)
            {
                if (book.Author == Author)
                {
                    string Data = string.Format("\n\nId: {0}\n\nTitle: {1}\n\nAuthor: {2}\n\nPrice: {3}\n\nAmount: {4}\n\n", this.Books.IndexOf(book), book.Title, book.Author, book.Price, book.Amount);

                    Console.WriteLine(Data);
                }
            }
        }

        // Books part end

        // Readers part start

        public void AddReader(Reader reader)
        {
            this.Readers.Add(reader);
        }

        public void RemoveReader(int index)
        {
            this.Readers.RemoveAt(index);
        }

        public void ShowReaders()
        {
            foreach (Reader reader in this.Readers)
            {
                string Data = string.Format("Id: {0}\n\nName: {1}\n\nSurname: {2}\n\nAge: {3}\n\nFine: {4}\n", Readers.IndexOf(reader),  reader.Name, reader.Surname, reader.Age, reader.Fine);

                Console.WriteLine(Data);
            }
        }

        public void SearchReader(string Name, string Surname)
        {
            foreach (Reader reader in Readers)
            {
                if (reader.Name == Name && reader.Surname == Surname) 
                {
                    string Data = string.Format("Id: {0}\n\nName: {1}\n\nSurname: {2}\n\nAge: {3}\n\nFine: {4}\n", Readers.IndexOf(reader), reader.Name, reader.Surname, reader.Age, reader.Fine);

                    Console.WriteLine(Data);
                }
            }
        }

        public void SetReaderFine(int index, int fine)
        {
            this.Readers[index].Fine = fine; 
        }

    }
}
