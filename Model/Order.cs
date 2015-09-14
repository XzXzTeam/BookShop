namespace Model
{
    /// <summary>
    /// On creating new order, you must create new StateTransition with state open.
    /// </summary>
    public class Order : PersistableObject
    {
        public User User { get; set; }
        public DeliveryAddress Address {get; set;}
    }
}
