#region usings

using System.Collections.Generic;

#endregion

namespace Model.Abstract
{
    public interface IBook : IPersistableObject
    {
        string Title { get; set; }
        string Description { get; set; }
        int Year { get; set; }
        IImage Splash { get; set; }
        IPublisher Publisher { get; set; }
        decimal Cost { get; set; }
        ICollection<IAuthor> Authors { get; set; }
        ICollection<IGenre> Genres { get; set; }
        ICollection<IBookLike> Likes { get; set; }
        ICollection<IReview> Reviews { get; set; }
    }
}