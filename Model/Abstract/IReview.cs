namespace Model
{
    using System;

    public interface IReview : IPersistableObject
    {
        IAuthor Author { get; set; }
        IBook Book { get; set; }
        string Content { get; set; }
        DateTime Date { get; set; }
        byte StarRate { get; set; }
    }
}
