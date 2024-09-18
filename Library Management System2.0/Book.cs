using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System2._0
{
    public class Book
    {
        private int _id;
        private string _title;
        private string _author;
        private int _isbn;
        private int _publicationYear;
        private int _stocks;

        public Book(int id,string title, string author, int isbn, int publicationYear, int stocks)
        {
            _id = id;
            _title = title;
            _author = author;
            _isbn = isbn;
            _publicationYear = publicationYear;
            _stocks = stocks;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public int Isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }

        public int PublicationYear
        {
            get { return _publicationYear; }
            set { _publicationYear = value; }
        }

        public int Stocks
        {
            get { return _stocks; }
            set { _stocks = value; }
        }

        public string InfoBook()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "Title " + Title + "\n";
            text += "Author " + Author + "\n";
            text += "Isbn " + Isbn + "\n";
            text += "Publication Year " + PublicationYear + "\n";
            text += "Stocks " + Stocks + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + Title + "," + Author + "," + Isbn + "," + PublicationYear + "," + Stocks;
        }
    }
}
