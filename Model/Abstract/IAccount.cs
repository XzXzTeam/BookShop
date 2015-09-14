#region usings

using System.Collections.Generic;
using Model.Enums;

#endregion

namespace Model.Abstract
{
    public interface IAccount : IPersistableObject
    {
        string Login { get; set; }
        string PasswordHash { get; set; }
        string Name { get; set; }
        AccountType Type { get; set; }
        ICollection<IBookLike> LikedBooks { get; set; }
        ICollection<IOrder> Orders { get; set; }
        ICollection<IDeliveryAddress> Addresses { get; set; }
        ICollection<IReview> Reviews { get; set; }
    }
}