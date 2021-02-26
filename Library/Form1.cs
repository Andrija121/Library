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
        private BookManagement b;
        private User u;
        public Form1()
        {
            InitializeComponent();
            b = new BookManagement();
            u = new User();
        }

        private void AddToListBox(ListBox listBox,List<string> list)
        {
            listBox.Items.Clear();
            foreach (var item in list)
            {
                listBox.Items.Add(item);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Book b1 = new Book(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value));
            

            bool result = b.AddBook(b1);
            if (result == false)
            {
                MessageBox.Show("Name already exists");
            }
            else
            {
                AddToListBox(listBox1, b.GetBooksInfo());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool reslut =u.AddUser(textBox3.Text);
            if(reslut==false)
            {
                MessageBox.Show("User already exists");
            }
            else
            {
                AddToListBox(listBox2, u.GetUsers());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            b.AddRegisteredBook(listBox1.SelectedItem.ToString(), listBox2.SelectedItem.ToString());
            AddToListBox(listBox3, b.GetRegisteredBook());
            AddToListBox(listBox1, b.GetBooksInfo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            b.ReturnBook(listBox3.SelectedItem.ToString());
            AddToListBox(listBox3, b.GetBooksInfo());
            AddToListBox(listBox1, b.GetRegisteredBook());
            
        }
    }
}
