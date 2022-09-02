using Abstract_LibrarySystem.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Abstract_LibrarySystem.Entities.Concrete
{
    public class Book : BaseBookEntity
    {
        //create book entities
        public string Title { get; set; }
        public string ISBN { get; set; }

        //encapsulation
        private double _price { get; set; }

        public double Price { get => _price; set => _price = value; }


        //constructor
        public Book()
        { 
        
        }
        public Book(int id, string title, double price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

    }
}
