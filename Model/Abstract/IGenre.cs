namespace Model
{
    using System.Collections.Generic;

    public interface IGenre : IPersistableObject
    {
        string Name { get; set; }
        ICollection<IBook> Books { get; set; }
    }
}