using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Creating Multilevel inheritancethe Class
    /// Creating a derived class from User / Person and adding the interface IManageable
    /// </summary>
    public class Librarian : User, IManageable
    {
        /// Declaring properties 
        public string Department { get; set; }
        public string InmmediateBoos { get; set; }

        //Defining the Parameterized Constructor
        public Librarian(string firstName, string lastName, string address, string phoneNumber,
            string email, string id, DateTime registerDate, string department,
            string inmediateBoss) :
        base(firstName, lastName, address, phoneNumber, email, id, registerDate)
        {
            Department = department;
            InmmediateBoos = inmediateBoss;
        }

        //Implementing the method from the interface 
        public void AddBook(Book book)
        {
            Console.WriteLine($"Book {book.Title} added to the library inventory by librarian {this.LastName},{this.FirstName}.");
        }

        //Implementing the method from the interface  
        public void RemoveBook(Book book)
        {
            Console.WriteLine($"Book {book.Title} was removed of the library inventory by librarian {this.LastName},{this.FirstName}.");
        }

    }
}
