using Abstract_LibrarySystem.Entities.Concrete;
using Abstract_LibrarySystem.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_LibrarySystem.Repositories.Concrete
{
    public class BookRepository : BaseBookRepository
    {
        public override void ClearTbox(TextBox tbx, TextBox tbx2)
        {
            tbx.Text = String.Empty;
            tbx2.Text = String.Empty;
        }

        public override void CreateBook(string title, double price)
        {
            Book book = new Book(5, title, price);
            SeedData.books.Add(book);
        }

        public override void DeleteBook(int id)
        {
            foreach (Book item in SeedData.books)
            {
                if (item.Id == id)
                {
                    SeedData.books.Remove(item);
                }
                else
                {
                    MessageBox.Show("Value Not Found..!");
                }
            }
        }

        public override void Find(int id, TextBox tbxModel, TextBox tbxPrice)
        {
            foreach (Book item in SeedData.books)
            {
                if (item.Id == id)
                {
                    tbxModel.Text = item.Title;
                    tbxPrice.Text = item.Price.ToString();
                }
            }
        }

        public override List<Book> GetBooks()
        {
            return SeedData.books.ToList();
        }

        public override void UpdateBook(int id, string title, double price)
        {
            Book book = new Book(5, title, price);
            foreach (Book item in SeedData.books)
            {
                if (item.Id == id)
                {
                    item.Title = title;
                    item.Price = price;
                }

            }
        }
    }
}
