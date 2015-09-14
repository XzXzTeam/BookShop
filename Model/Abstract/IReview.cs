#region usings

using System;

#endregion

namespace Model.Abstract
{
    public interface IReview : IPersistableObject
    {
        IAuthor Author { get; set; }
        IBook Book { get; set; }
        string Content { get; set; }
        DateTime Date { get; set; }
        byte StarRate { get; set; }
    }
}