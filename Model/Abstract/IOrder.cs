#region usings

using System;
using Model.Enums;

#endregion

namespace Model.Abstract
{
    public interface IOrder : IPersistableObject
    {
        IDeliveryAddress Address { get; set; }
        IBook Book { get; set; }
        DateTime ChangeDate { get; set; }
        OrderState CurrentState { get; set; }
    }
}