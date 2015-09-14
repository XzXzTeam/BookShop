#region usings

using Model.Abstract;

#endregion

namespace Persistence.Entities.Base
{
    public class PersistableEntity : IPersistableObject
    {
        public int Id { get; set; }
    }
}