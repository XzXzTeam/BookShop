#region usings

using System;
using Model.Abstract;
using Persistence.Entities.Base;

#endregion

namespace Persistence.Entities
{
    public class ReviewEntity : PersistableEntity, IReview
    {
        public IAuthor Author { get; set; }
        public IBook Book { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public byte StarRate { get; set; }
    }
}