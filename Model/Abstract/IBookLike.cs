#region usings

using Model.Enums;

#endregion

namespace Model.Abstract
{
    public interface IBookLike : IPersistableObject
    {
        IAccount Account { get; set; }
        IBook Book { get; set; }
        LikeType Type { get; set; }
    }
}