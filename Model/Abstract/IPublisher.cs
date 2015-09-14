namespace Model.Abstract
{
    public interface IPublisher : IPersistableObject
    {
        string Name { get; set; }
        string City { get; set; }
    }
}