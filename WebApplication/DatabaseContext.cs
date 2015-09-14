namespace WebApplication
{
    using Model;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabaseContext : DbContext
    {
        // Контекст настроен для использования строки подключения "DatabaseContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "WebApplication.DatabaseContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "DatabaseContext" 
        // в файле конфигурации приложения.
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<BookLike> Likes { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Publisher> Publishers { get; set; }
        public virtual DbSet<Review> Rewiews { get; set; }
    }

}