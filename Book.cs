using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Declaring a Hierarchical Inheritance - creating the parent class Book 
    /// </summary>
    public class Book
    {
        //Defining the properties of the parent class
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublicacionYear { get; set; }
        public string Genre { get; set; }
        public string IsAvailable { get; set; }

        //Defining the Parameterized Constructor
        public Book(string title, string author, int publicationYear, string genre, 
            string isAvailable )
        {
            Title = title;
            Author = author;
            PublicacionYear = publicationYear;
            Genre = genre;
            IsAvailable = isAvailable;
        }
    }
}
