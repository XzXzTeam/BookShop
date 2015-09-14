﻿

using System.Collections.Generic;

namespace Model
{
    using System;

    public interface IOrder : IPersistableObject
    {
        IDeliveryAddress Address {get; set;}
        IBook Book { get; set; }
        DateTime ChangeDate { get; set; }
        OrderState CurrentState { get; set; }
    }
}
