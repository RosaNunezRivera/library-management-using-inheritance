using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Creating Multilevel inheritancethe Class
    /// Class User derived from class Person. After class member and class librarian is derived 
    /// from Sub Class User 
    /// </summary>
    public class User : Person
    {
        //Declaring properties 
        public string Id { get; set; }
        public DateTime RegistrationDate { get; set; }

        //Defining the Parameterized Constructor
        public User(string firstName, string lastName, string address, string phoneNumber, string email, string id, DateTime registrationDate):
            base(firstName, lastName, address, phoneNumber, email)
        {
            Id = id;
            RegistrationDate = registrationDate;
        }
    }
}
