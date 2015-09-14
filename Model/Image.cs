namespace Model
{
    using System;

    public class Image : PersistableObject
    {
        public string RelativePath { get; set; }

        public Image GetContent()
        {
            throw new NotImplementedException();
        }
    }
}
