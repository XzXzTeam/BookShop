﻿namespace Model
{
    public interface IDeliveryAddress : IPersistableObject
    {
        string Address { get; set; }
        IAccount Account { get; set; }
    }
}