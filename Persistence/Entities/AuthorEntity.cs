#region usings

using Model.Abstract;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class AuthorEntity : PersistableEntity, IAuthor
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IImage Photo { get; set; }
    }
}