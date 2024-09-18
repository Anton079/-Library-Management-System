using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System2._0
{
    public class Catalog
    {
        private List<Book> books;

        public Catalog()
        {
            books = new List<Book>();
            LoadData();
        }

        public void LoadData()
        {
            books.Add(new Book(1,"dwada","Antonio",123,1975,3));
            books.Add(new Book(2, "cvxcv", "Marius", 321, 54774,5));
            books.Add(new Book(3, "htyht", "Levia", 4234, 45754,8));

        }

        public void AfisareBooks()
        {
            foreach(Book book in books)
            {
                Console.WriteLine(book.InfoBook());
            }
        }

        public bool SearchBook(int idBook)
        {
            foreach(Book x in books)
            {
                if(x.Id == idBook)
                {
                    return true;
                }
            }
            return false;
        }

        public Book ReturnBookById(int idBook)
        {
            foreach( Book x in books)
            {
                if(x.Id == idBook)
                {
                    return x;
                }
            }
            return null;
        }
    }
}
