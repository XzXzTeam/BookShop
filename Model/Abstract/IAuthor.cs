namespace Model.Abstract
{
    public interface IAuthor : IPersistableObject
    {
        string Name { get; set; }
        string Surname { get; set; }
        IImage Photo { get; set; }
    }
}
