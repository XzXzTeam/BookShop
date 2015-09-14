#region usings

using System.Collections.Generic;
using Model.Abstract;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class GenreEntitiy : PersistableEntity, IGenre
    {
        public string Name { get; set; }
        public ICollection<IBook> Books { get; set; }
    }
}