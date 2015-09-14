using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public class Genre : PersistableObject
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}