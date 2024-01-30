using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Creating Multilevel inheritancethe Class
    /// Creating a derived class from User / Person and adding the Implementation called IBorrowable
    /// </summary>
    public class Member : User, IBorrowable
    {
        //Declaring property
        public string IdLastBookBorrow { get; set; }


        //Defining the Parameterized Constructor
        public Member(string firstName, string lastName, string address, string phoneNumber, string email, string id, DateTime registrationDate, string idLastBookBorrow) :
            base(firstName, lastName, address, phoneNumber, email, id, registrationDate)
        {
            IdLastBookBorrow = idLastBookBorrow;
        }

        //Implementing the method from the interface 
        public void Borrow(Book book)
        {
            Console.WriteLine($"The member {this.FirstName} is borrowing the book {book.Title}");
        }
    }
}
