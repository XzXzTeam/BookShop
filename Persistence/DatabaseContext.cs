#region usings

using System.Data.Entity;
using Persistence.Entities;

#endregion

namespace Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        public virtual DbSet<AccountEntity> Accounts { get; set; }
        public virtual DbSet<AuthorEntity> Authors { get; set; }
        public virtual DbSet<BookEntity> Books { get; set; }
        public virtual DbSet<BookLikeEntity> Likes { get; set; }
        public virtual DbSet<DiliveryAddressEntity> DeliveryAddresses { get; set; }
        public virtual DbSet<GenreEntitiy> Genres { get; set; }
        public virtual DbSet<ImageEntity> Images { get; set; }
        public virtual DbSet<OrderEntity> Orders { get; set; }
        public virtual DbSet<PublisherEntity> Publishers { get; set; }
        public virtual DbSet<ReviewEntity> Reviews { get; set; }
    }
}