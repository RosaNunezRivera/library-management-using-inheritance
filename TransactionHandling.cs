using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Creating a static class & static method to perform the operation of update book.IsAvailable  
    /// </summary>
    public static class TransactionHandling 
    {
        public static void Borrow(Book book)
        {
            book.IsAvailable = "Not Available";
            Console.WriteLine($"The book {book.Title} was borrow! Now the state is {book.IsAvailable}"); 
        }

        public static void Return(Book book)
        {
            book.IsAvailable = "Is Available";
            Console.WriteLine($"The book {book.Title} was returned! Now the state is {book.IsAvailable}");
        }
    }
}
