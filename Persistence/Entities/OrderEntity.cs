#region usings

using System;
using Model.Abstract;
using Model.Enums;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class OrderEntity : PersistableEntity, IOrder
    {
        public IDeliveryAddress Address { get; set; }
        public IBook Book { get; set; }
        public DateTime ChangeDate { get; set; }
        public OrderState CurrentState { get; set; }
    }
}