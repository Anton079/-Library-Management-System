using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System2._0
{
    public class Librarian : Actions
    {
        private Catalog catalog;
         

        public Librarian()
        {
            catalog = new Catalog();
        }

        public override void DisplayBooks()
        {
            catalog.AfisareBooks();
        }

        public override void BarrowBook(int idBook)
        {
            Book x = catalog.ReturnBookById(idBook);

            if (catalog.SearchBook(idBook))
            {
                Console.WriteLine("O carte a fost scoasa pe stock!");
                x.Stocks -= 1;
            }
        }

        public override void ReturnBook(int idBook)
        {
            Book x = catalog.ReturnBookById(idBook);

            if (catalog.SearchBook(idBook))
            {
                Console.WriteLine("O carte a fost adaugata pe stock!");
                x.Stocks += 1;
            }
        }
    }
}
