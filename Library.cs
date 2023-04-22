using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен
{
    internal class Library
    {
        //private Book _book;
        //private Author _author;
        private string _name;
        //public Book Book
        //{
        //    get { return _book; }
        //}
        public string Name {
            get { return _name; }
            set { _name = value; }
        }
        //private Author Author
        //{
        //    get { return _author; }
        //}
        public Library(/*Book book, Author author,*/ string name)
        {
            name = _name;
            //author = _author;
            //book = _book;
        }
    }
}

