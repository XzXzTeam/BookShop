namespace Model
{
    public interface IPublisher : IPersistableObject
    {
        string Name { get; set; }
        string City { get; set; }
    }
}
