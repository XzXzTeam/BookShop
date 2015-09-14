namespace Model.Abstract
{
    public interface IImage : IPersistableObject
    {
        string RelativePath { get; set; }
    }
}
