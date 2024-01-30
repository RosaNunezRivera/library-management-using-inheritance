using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace librarymanagementusinginheritance
{
    /// <summary>
    /// Creating an interface to implemented in member class
    /// </summary>
    public interface IBorrowable
    {
        void Borrow(Book book);
    }
}
