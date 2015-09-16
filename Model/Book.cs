#region usings

using System.Collections.Generic;
using AbstractModel;

#endregion

namespace Model
{
    public class Book : PersistableObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Image Splash { get; set; }
        public Publisher Publisher { get; set; }
        public decimal Cost { get; set; }
        public ICollection<Author> Authors { get; set; }
        public ICollection<Genre> Genres { get; set; }
        public ICollection<BookLike> Likes { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}