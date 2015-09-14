#region usings

using Model.Abstract;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class ImageEntity : PersistableEntity, IImage
    {
        public string RelativePath { get; set; }
    }
}