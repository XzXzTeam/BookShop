namespace Model
{
    using System.Collections.Generic;

    public class User : Account
    {
        public IEnumerable<BookLike> LikedBooks { get; set; }
        public IEnumerable<DeliveryAddress> Addresses { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
    