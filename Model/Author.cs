namespace Model
{
    public class Author : PersistableObject
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Image Photo { get; set; }
    }
}
