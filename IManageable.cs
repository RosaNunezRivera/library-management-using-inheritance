using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Creating an interface to implemented in librarian class
    /// </summary>
    public interface IManageable
    {
        ///Method signature called AddBook
        void AddBook(Book book);

        ///Method signature called RemoveBook
        void RemoveBook(Book book);


    }
}
