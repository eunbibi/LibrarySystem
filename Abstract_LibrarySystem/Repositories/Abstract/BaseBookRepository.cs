using Abstract_LibrarySystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstract_LibrarySystem.Repositories.Abstract
{
    public abstract class BaseBookRepository
    {
        //create CRUD operations
        public abstract List<Book> GetBooks();
        public abstract void CreateBook(string title, double price);
        public abstract void UpdateBook(int id, string title, double price);
        public abstract void DeleteBook(int id);
        public abstract void Find(int id, TextBox tbxModel, TextBox tbxPrice);
        public abstract void ClearTbox(TextBox tbx, TextBox tbx2);
    }
}
