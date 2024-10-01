using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System2._0
{
    public interface IActions
    {

        void DisplayBooks();

        void BarrowBook(int idBook);

        void ReturnBook(int idBook);
    }
}
