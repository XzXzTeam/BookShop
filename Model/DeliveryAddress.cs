namespace Model
{
    public class DeliveryAddress : PersistableObject
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public User User { get; set; }
    }
}
