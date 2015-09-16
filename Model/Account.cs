#region usings

using System.Collections.Generic;
using AbstractModel;

#endregion

namespace Model
{
    public class Account : PersistableObject
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public ICollection<BookLike> LikedBooks { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<DeliveryAddress> Addresses { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}