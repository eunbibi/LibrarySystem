using Abstract_LibrarySystem.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LibrarySystem
{
    public static class SeedData
    {
        public static List<Book> books = new List<Book>()
        {
            new Book {Id=1, Title = "VERITY", Price= 12.00 },
            new Book {Id=2,Title="BREAKING HISTORY",Price=35.00},
            new Book {Id=3,Title="BABEL",Price=45.00},
            new Book {Id=4,Title="ALL GOOD PEOPLE HERE",Price=21.00},
        };
    }
}
