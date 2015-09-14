namespace Model
{
    public class BookLike : PersistableObject
    {
        public User User { get; set; }
        public Book Book { get; set; }
        public LikeType Type { get; set; }
    }
}
