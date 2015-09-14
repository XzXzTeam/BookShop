#region usings

using Model.Abstract;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class PublisherEntity : PersistableEntity, IPublisher
    {
        public string Name { get; set; }
        public string City { get; set; }
    }
}