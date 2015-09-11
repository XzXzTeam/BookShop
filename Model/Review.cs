namespace Model
{
    using System;

    public class Review : PersistableObject
    {
        public User Author { get; set; }
        public Book Book { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public byte StarRate { get; set; }
    }
}
