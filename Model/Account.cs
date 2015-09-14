using System.Collections.Generic;

namespace Model
{
    public abstract class Account : PersistableObject
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public IEnumerable<BookLike> LikedBooks { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<DeliveryAddress> Addresses { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
    }
}
