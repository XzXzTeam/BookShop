namespace Model
{
    using System;

    public class StateTransition : PersistableObject
    {
        public Order Order { get; set; }
        public StateTransition OldState { get; set; }
        public OrderState NewStatus { get; set; }
        public Account User { get; set; }
        public DateTime Date { get; set; }
    }
}
