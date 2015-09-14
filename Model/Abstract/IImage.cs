namespace Model
{
    public interface IImage : IPersistableObject
    {
        string RelativePath { get; set; }
    }
}
