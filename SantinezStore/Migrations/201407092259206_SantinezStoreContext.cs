namespace SantinezStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SantinezStoreContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 128),
                        Password = c.String(nullable: false, maxLength: 200),
                        Name = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        Phone = c.String(nullable: false),
                        Created = c.DateTime(nullable: false),
                        ConfirmedEmail = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Email);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
