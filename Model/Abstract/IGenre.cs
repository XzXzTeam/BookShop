#region usings

using System.Collections.Generic;

#endregion

namespace Model.Abstract
{
    public interface IGenre : IPersistableObject
    {
        string Name { get; set; }
        ICollection<IBook> Books { get; set; }
    }
}