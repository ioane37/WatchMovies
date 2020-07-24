namespace WatchMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingGenres : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Genres",
                c => new {
                    Id = c.Byte(nullable: false, identity: true),
                    Name = c.String()
                }).PrimaryKey(t => t.Id);

            Sql("INSERT INTO Genres (Name) Values('Action')");
            Sql("INSERT INTO Genres (Name) Values('Horror')");
            Sql("INSERT INTO Genres (Name) Values('Comedy')");
            Sql("INSERT INTO Genres (Name) Values('Detective')");
        }
        
        public override void Down()
        {
        }
    }
}
