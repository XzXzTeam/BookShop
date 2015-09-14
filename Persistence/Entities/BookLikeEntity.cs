#region usings

using Model.Abstract;
using Model.Enums;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class BookLikeEntity : PersistableEntity, IBookLike
    {
        public IAccount Account { get; set; }
        public IBook Book { get; set; }
        public LikeType Type { get; set; }
    }
}