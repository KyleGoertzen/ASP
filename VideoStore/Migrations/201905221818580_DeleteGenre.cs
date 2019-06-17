namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteGenre : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "Genre_Id", "dbo.Genres");
            DropIndex("dbo.Customers", new[] { "Genre_Id" });
            DropColumn("dbo.Customers", "GenreId");
            DropColumn("dbo.Customers", "Genre_Id");
            DropTable("dbo.Genres");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Customers", "Genre_Id", c => c.Int());
            AddColumn("dbo.Customers", "GenreId", c => c.Byte(nullable: false));
            CreateIndex("dbo.Customers", "Genre_Id");
            AddForeignKey("dbo.Customers", "Genre_Id", "dbo.Genres", "Id");
        }
    }
}
