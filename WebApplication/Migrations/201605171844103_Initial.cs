namespace WebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Accounts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        PasswordHash = c.String(),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DeliveryAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.BookLikes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        Account_Id = c.Int(),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Account_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Year = c.Int(nullable: false),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Publisher_Id = c.Int(),
                        Splash_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Publishers", t => t.Publisher_Id)
                .ForeignKey("dbo.Images", t => t.Splash_Id)
                .Index(t => t.Publisher_Id)
                .Index(t => t.Splash_Id);
            
            CreateTable(
                "dbo.Authors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Photo_Id = c.Int(),
                        Book_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Images", t => t.Photo_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .Index(t => t.Photo_Id)
                .Index(t => t.Book_Id);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RelativePath = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Publishers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        Date = c.DateTime(nullable: false),
                        StarRate = c.Byte(nullable: false),
                        Author_Id = c.Int(),
                        Book_Id = c.Int(),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Authors", t => t.Author_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Author_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ChangeDate = c.DateTime(nullable: false),
                        CurrentState = c.Int(nullable: false),
                        Address_Id = c.Int(),
                        Book_Id = c.Int(),
                        Account_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DeliveryAddresses", t => t.Address_Id)
                .ForeignKey("dbo.Books", t => t.Book_Id)
                .ForeignKey("dbo.Accounts", t => t.Account_Id)
                .Index(t => t.Address_Id)
                .Index(t => t.Book_Id)
                .Index(t => t.Account_Id);
            
            CreateTable(
                "dbo.GenreBooks",
                c => new
                    {
                        Genre_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Genre_Id, t.Book_Id })
                .ForeignKey("dbo.Genres", t => t.Genre_Id, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.Book_Id, cascadeDelete: true)
                .Index(t => t.Genre_Id)
                .Index(t => t.Book_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Orders", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.Orders", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Orders", "Address_Id", "dbo.DeliveryAddresses");
            DropForeignKey("dbo.Books", "Splash_Id", "dbo.Images");
            DropForeignKey("dbo.Reviews", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Reviews", "Author_Id", "dbo.Authors");
            DropForeignKey("dbo.Books", "Publisher_Id", "dbo.Publishers");
            DropForeignKey("dbo.BookLikes", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.GenreBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.GenreBooks", "Genre_Id", "dbo.Genres");
            DropForeignKey("dbo.Authors", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.Authors", "Photo_Id", "dbo.Images");
            DropForeignKey("dbo.BookLikes", "Account_Id", "dbo.Accounts");
            DropForeignKey("dbo.DeliveryAddresses", "Account_Id", "dbo.Accounts");
            DropIndex("dbo.GenreBooks", new[] { "Book_Id" });
            DropIndex("dbo.GenreBooks", new[] { "Genre_Id" });
            DropIndex("dbo.Orders", new[] { "Account_Id" });
            DropIndex("dbo.Orders", new[] { "Book_Id" });
            DropIndex("dbo.Orders", new[] { "Address_Id" });
            DropIndex("dbo.Reviews", new[] { "Account_Id" });
            DropIndex("dbo.Reviews", new[] { "Book_Id" });
            DropIndex("dbo.Reviews", new[] { "Author_Id" });
            DropIndex("dbo.Authors", new[] { "Book_Id" });
            DropIndex("dbo.Authors", new[] { "Photo_Id" });
            DropIndex("dbo.Books", new[] { "Splash_Id" });
            DropIndex("dbo.Books", new[] { "Publisher_Id" });
            DropIndex("dbo.BookLikes", new[] { "Book_Id" });
            DropIndex("dbo.BookLikes", new[] { "Account_Id" });
            DropIndex("dbo.DeliveryAddresses", new[] { "Account_Id" });
            DropTable("dbo.GenreBooks");
            DropTable("dbo.Orders");
            DropTable("dbo.Reviews");
            DropTable("dbo.Publishers");
            DropTable("dbo.Genres");
            DropTable("dbo.Images");
            DropTable("dbo.Authors");
            DropTable("dbo.Books");
            DropTable("dbo.BookLikes");
            DropTable("dbo.DeliveryAddresses");
            DropTable("dbo.Accounts");
        }
    }
}
