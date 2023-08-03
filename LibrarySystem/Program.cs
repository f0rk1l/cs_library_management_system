using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library;

            try
            {
                using (FileStream fileStream = new FileStream("data_file.dat", FileMode.OpenOrCreate))
                {
                    BinaryFormatter bf = new BinaryFormatter();

                    library = (Library) bf.Deserialize(fileStream);
                }
            } 
            
            catch (SerializationException ex)
            {
                library = new Library();
            }

            string Title;

            string Author;

            string Name;

            string Surname;

            int Id;

            while (true)
            {
                Console.Write("Choose action:\n\n[1] Add book\n\n[2] Remove book\n\n[3] Show all books\n\n[4] Search book by title\n\n[5] Search books by author\n\n[6] Add reader\n\n[7] Remove reader\n\n[8] Show readers\n\n[9] Search reader\n\n[10] Set reader fine\n\n[11] Exit\n\nChoose: ");
                int Choose = Convert.ToInt32(Console.ReadLine());

                switch (Choose)
                {
                    case 1:

                        Console.Write("\n\nEnter title: ");
                        Title = Console.ReadLine();

                        Console.Write("Enter author: ");
                        Author = Console.ReadLine();

                        Console.Write("Enter price: ");
                        int Price = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter amount: ");
                        int Amount = Convert.ToInt32(Console.ReadLine());

                        Book book = new Book(Title, Author, Price, Amount);

                        library.AddBook(book);

                        break;

                    case 2:

                        Console.Write("\n\nEnter ID: ");
                        Id = Convert.ToInt32(Console.ReadLine());

                        library.RemoveBook(Id);

                        break;

                    case 3:

                        library.ShowBooks();
                        break;

                    case 4:

                        Console.Write("\n\nEnter title: ");
                        Title = Console.ReadLine();

                        library.SearchBooksByTitle(Title);

                        break;

                    case 5:

                        Console.Write("\n\nEnter author: ");
                        Author = Console.ReadLine();

                        library.SearchBooksByAuthor(Author);

                        break;

                    case 6:

                        Console.Write("\n\nEnter name: ");
                        Name = Console.ReadLine();

                        Console.Write("Enter surname: ");
                        Surname = Console.ReadLine();

                        Console.Write("Enter age: ");
                        int Age = Convert.ToInt32(Console.ReadLine());

                        Reader reader = new Reader(Name, Surname, Age);

                        library.AddReader(reader);

                        break;

                    case 7:

                        Console.Write("\n\nEnter ID: ");
                        Id = Convert.ToInt32(Console.ReadLine());

                        library.RemoveReader(Id);

                        break;

                    case 8:

                        Console.WriteLine("\n");

                        library.ShowReaders();

                        break;

                    case 9:

                        Console.Write("\n\nEnter name: ");
                        Name = Console.ReadLine();

                        Console.Write("Enter surname: ");
                        Surname = Console.ReadLine();

                        library.SearchReader(Name, Surname);

                        break;

                    case 10:

                        Console.Write("\n\nEnter reader ID: ");
                        Id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Enter reader's fine: ");
                        int Fine = Convert.ToInt32(Console.ReadLine());

                        library.SetReaderFine(Id, Fine);

                        break;

                    case 11:

                        using (FileStream fs = new FileStream("data_file.dat", FileMode.OpenOrCreate))
                        {
                            BinaryFormatter formatter = new BinaryFormatter();

                            formatter.Serialize(fs, library);
                        }

                        Console.WriteLine();

                        return;

                    default:

                        Console.WriteLine("\n\nIncorrect choose\n");
                        break;
                }

                Console.Write("\n\nPress some button to clear output...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
