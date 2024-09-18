using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System2._0
{
    public class Actions
    {

        public virtual void DisplayBooks()
        {
            Console.WriteLine("base");
        }

        public virtual void BarrowBook(int idBook)
        {
            Console.WriteLine("base");
        }

        public virtual void ReturnBook(int idBook)
        {
            Console.WriteLine("base");
        }
    }
}
