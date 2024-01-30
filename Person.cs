using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Creating Multilevel inheritancethe Class person (parent class) and deriven from it users and after 
    /// derived member and librarian
    /// </summary>
    public class Person
    {
        //Declaring properties 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        //Defining the Parameterized Constructor
        public Person(string firstName, string lastName, string address, string phoneNumber, string email) 
        { 
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }
}
