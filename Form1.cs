using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Экзамен
{
    public partial class Form1 : Form
    {
        private Book _book;
        internal List<Library> Libraries { get; private set; }
        internal List<Author> Authors { get; private set; }
        internal List<Book> Books { get; private set; }
        public Form1()
        {
            _book = new Book("");
            InitializeComponent();
            Libraries = new List<Library>()
            {
              new Library("Республиканская библиотека")
            };
            Books = new List<Book>()
            {
                new Book("Война и мир"),
                new Book("алалва"),
                new Book("помогите")
            };
            Authors = new List<Author>()
            {
                new Author("Лев","Толстой")
            };
            dataGridView1.DataSource = Libraries;
            dataGridView1.DataSource = Authors;
            dataGridView1.DataSource = Books;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {



                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    dataGridView1.DataSource = Books.ToList();
                }
                else
                {
                    var initials = Books.Where(s => s.Name.ToLower().Contains(textBox1.Text.ToLower())).ToList();
                    dataGridView1.DataSource = initials;
                }
            }
        }
    }

