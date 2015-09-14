

using System.Collections.Generic;

namespace Model
{
    using System;
    /// <summary>
    /// On creating new order, you must create new StateTransition with state open.
    /// </summary>
    public class Order : PersistableObject
    {
        public DeliveryAddress Address {get; set;}
        public Book Book { get; set; }
        public DateTime ChangeDate { get; set; }
        public OrderState CurrentState { get; set; }
    }
}
