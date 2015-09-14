#region usings

using System.Collections.Generic;
using Model.Abstract;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class BookEntity : PersistableEntity, IBook
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public IImage Splash { get; set; }
        public IPublisher Publisher { get; set; }
        public decimal Cost { get; set; }
        public ICollection<IAuthor> Authors { get; set; }
        public ICollection<IGenre> Genres { get; set; }
        public ICollection<IBookLike> Likes { get; set; }
        public ICollection<IReview> Reviews { get; set; }
    }
}