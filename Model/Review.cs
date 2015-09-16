#region usings

using System;
using AbstractModel;

#endregion

namespace Model
{
    public class Review : PersistableObject
    {
        public Author Author { get; set; }
        public Book Book { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public byte StarRate { get; set; }
    }
}