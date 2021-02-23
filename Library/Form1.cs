using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    
    public partial class Form1 : Form
    {
        private Book b;
        private User u;
        public Form1()
        {
            InitializeComponent();
            b = new Book();
            u = new User();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            var a = Convert.ToInt32(numericUpDown1.Value);
            b.AddBook(textBox1.Text, textBox2.Text, a);
                foreach (var book in b.GetBookInfos())
                {
                
                listBox1.Items.Add(book.GetInfo());
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            u.AddUser(textBox3.Text);
            foreach (var user in u.GetUsers())
            {
                listBox2.Items.Add(user);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
