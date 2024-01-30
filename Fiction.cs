using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Declaring a Hierarchical Inheritance - creating the chiild class Fiction from parent class
    /// Book
    /// </summary>
    class Fiction : Book
    {
        //Defining the properties of the child class
        string MainCharacter { get; set; }

        //Defining the Parameterized Constructor
        public Fiction(string title, string author, int publicationYear, string genre,
            string mainCharacter, string isAvailable) :
            base(title, author, publicationYear, genre, isAvailable)
        {
            MainCharacter = mainCharacter;
        }
    }
}
