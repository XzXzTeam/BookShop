namespace Model
{
    using System.Collections.Generic;

    public class Book : PersistableObject
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Image Splash { get; set; }
        public Publisher Publisher { get; set; }
        public decimal Cost { get; set; }
        public IEnumerable<Author> Authors { get; set; }
        public IEnumerable<BookLike> Likes { get; set; }
        public IEnumerable<Review> Reviews { get; set; }

    }
}
