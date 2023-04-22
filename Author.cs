using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Экзамен
{
    internal class Author
    {
        private string _firstName;
        private string _lastName;
        public string FirstName {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public Author(string firstname, string lastname)
        {
            firstname = _firstName;
            lastname = _lastName;
        }
    }
}
