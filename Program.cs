using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    internal class Program
    {
        /// <summary>
        /// Program to show the application of Hierarchical Inheritance and multi inheritance
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 2 - Library Management using Inheritance");
            Console.WriteLine("Scenario: Library Management\n");

            Console.WriteLine("1.User Roles");
            Console.WriteLine("-------------");
            // Creating a new members 
            Member member1 = new Member("Rosa", "Nunez", "300 Nice Street", "431-9000", "rosa77@gmail.com", "M001", DateTime.Now, "");
            Member member2 = new Member("Enrique", "Lopez", "200 Goulet Street", "431-9999", "elo77@gmail.com", "M002", DateTime.Now, "");
            Console.WriteLine($"The member {member1.LastName},{member1.FirstName} was created");
            Console.WriteLine($"The member {member2.LastName},{member2.FirstName} was created");

            // Creating a new Librarian
            Librarian librarian1 = new Librarian(
                "Susan",
                "Lopez",
                "100 Portage Ave",
                "431-253400",
                "susanlopez@gmail.com",
                "L001",
                DateTime.Now,
                "Library",
                "John Smith"
            );
            Console.WriteLine($"The ligrarian {librarian1.LastName},{librarian1.FirstName} was created");

            Console.WriteLine("\n2.Book Categories");
            Console.WriteLine("-----------------");

            //Creating a fiction books
            Fiction book1 = new Fiction("Echoes of the Past", "Sandra Williams", 2000, "Fiction", "Echoes" , "Available");
            Fiction book2 = new Fiction("The Lost World", "Michael Crichton", 1995, "Science Fiction", "Jurassic Park", "Available");
            Fiction book3 = new Fiction("The Fellowship of the Ring", "J.R.R. Tolkien", 1954, "Fantasy", "The Lord of the Rings", "available"); 

            Console.WriteLine($"The book {book1.Title}, {book1.Author}, {book1.Genre} was created");
            Console.WriteLine($"The book {book2.Title}, {book2.Author}, {book2.Genre} was created");
            Console.WriteLine($"The book {book3.Title}, {book3.Author}, {book3.Genre} was created");

            //Creating a non-fiction book
            NonFiction book4 = new NonFiction("Marie Curie: A Life", "Susan Quinn", 1995, "Non-Fiction", "Biografy", "Available");
            NonFiction book5 = new NonFiction("Sapiens: A Brief History of Humankind", "Yuval Noah Harari", 2014, "Non-Fiction", "History", "Available");
            NonFiction book6 = new NonFiction("The Power of Habit: Why We Do What We Do in Life and Business", "Charles Duhigg", 2012, "Non-Fiction", "Psychology", "Available");

            Console.WriteLine($"The book {book4.Title}, {book4.Author}, {book4.Genre} was created");
            Console.WriteLine($"The book {book5.Title}, {book5.Author}, {book5.Genre} was created");
            Console.WriteLine($"The book {book6.Title}, {book6.Author}, {book6.Genre} was created");
            
            Console.WriteLine("\n3.Transaction Handling");
            Console.WriteLine("-------------------------");
            // Updating the book.IsAvailable "Not Available" when the books was borrow
            //Using a static method 
            TransactionHandling.Borrow(book1);
            TransactionHandling.Borrow(book3);
            TransactionHandling.Borrow(book5);
            TransactionHandling.Borrow(book6);

            TransactionHandling.Return(book1);
            TransactionHandling.Return(book3);

            Console.WriteLine("\n4.Interfaces for Funtionality");
            Console.WriteLine("--------------------------------");
            // allowing librarian add a book 
            librarian1.AddBook(book1);
            librarian1.AddBook(book2);
            librarian1.AddBook(book3);
            librarian1.AddBook(book4);
            librarian1.AddBook(book5);
            librarian1.AddBook(book6);

            //Allowing member borrow a book 
            member1.Borrow(book1);
            member1.Borrow(book3);
            member2.Borrow(book5);
            member2.Borrow(book6);

            //Allowing librarian remove a book 
            librarian1.RemoveBook(book2);
            librarian1.RemoveBook(book6);

            Console.ReadKey();
        }
    }
}
