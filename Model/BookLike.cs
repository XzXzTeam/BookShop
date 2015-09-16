#region usings

using AbstractModel;

#endregion

namespace Model
{
    public class BookLike : PersistableObject
    {
        public Account Account { get; set; }
        public Book Book { get; set; }
        public LikeType Type { get; set; }
    }
}