using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System2._0
{
    public class User
    {
        private int _id;
        private string _name;
        private string _barrow;

        public User(int id, string name, string barrow)
        {
            _id = id;
            _name = name;
            _barrow = barrow;
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Barrow
        {
            get { return _barrow; }
            set { _barrow = value; }
        }

        public string InfoUser()
        {
            string text = " ";

            text += "Id " + Id + "\n";
            text += "Name " + Name + "\n";
            text += "Barrow " + Barrow + "\n";
            return text;
        }

        public string ToSave()
        {
            return Id + "," + Name + "," + Barrow;
        }
    }
}
