#region usings

using System.Collections.Generic;
using Model.Abstract;
using Model.Enums;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class AccountEntity : PersistableEntity, IAccount
    {
        public string Login { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public AccountType Type { get; set; }
        public ICollection<IBookLike> LikedBooks { get; set; }
        public ICollection<IOrder> Orders { get; set; }
        public ICollection<IDeliveryAddress> Addresses { get; set; }
        public ICollection<IReview> Reviews { get; set; }
    }
}