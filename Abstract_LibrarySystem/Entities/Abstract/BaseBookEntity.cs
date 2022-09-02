using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_LibrarySystem.Entities.Abstract
{
    public abstract class BaseBookEntity
    {
        //create base book entites
        public int Id { get; set; }


        private DateTime _dateTime = DateTime.Now;
        public DateTime CreateTime { get => _dateTime; set => _dateTime = value; }

    }
}
