using Abstract_LibrarySystem.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Abstract_LibrarySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //repo that contains crud methods instantiated
        BookRepository bookRepository = new BookRepository();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bookRepository.GetBooks();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookRepository.CreateBook(textBox1.Text, Convert.ToDouble(textBox2.Text));
            dataGridView1.DataSource = bookRepository.GetBooks();
            bookRepository.ClearTbox(textBox1, textBox2);
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            bookRepository.Find(Convert.ToInt32(txtFindId.Text), txtUpdateModel, txtUpdatePrice);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            bookRepository.UpdateBook(Convert.ToInt32(txtFindId.Text), txtUpdateModel.Text, Convert.ToDouble(txtUpdatePrice.Text));
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
