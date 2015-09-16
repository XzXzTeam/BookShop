#region usings

using System;
using AbstractModel;

#endregion

namespace Model
{
    public class Image : PersistableObject
    {
        public string RelativePath { get; set; }

        public Image GetContent()
        {
            throw new NotImplementedException();
        }
    }
}