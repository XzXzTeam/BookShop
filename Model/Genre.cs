#region usings

using System.Collections.Generic;
using AbstractModel;

#endregion

namespace Model
{
    public class Genre : PersistableObject
    {
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}