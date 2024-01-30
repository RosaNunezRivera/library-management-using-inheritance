using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Declaring a Hierarchical Inheritance - creating the child class NonFiction from parent class
    /// Book
    /// </summary>
    public class NonFiction : Book
    {
        //Defining the properties of the child class
        string Topic {  get; set; }

        //Defining the Parameterized Constructor
        public NonFiction(string title, string author, int publicationYear, string genre, 
            string topic, string isAvailable) :
            base(title, author, publicationYear, genre, isAvailable)
        {
            Topic = topic;
        }
    }
}
