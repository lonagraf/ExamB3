using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен
{
    internal class Book
    {
        private string _name;
        public string Name {
        get { return _name; }
        set { _name = value; }
        }
        public Book(string name) { 
        _name = name;
        }
    }
}
