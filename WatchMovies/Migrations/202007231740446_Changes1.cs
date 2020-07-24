namespace WatchMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "TrailerLink", c => c.String());
            AddColumn("dbo.Movies", "ActualMovie", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "ActualMovie");
            DropColumn("dbo.Movies", "TrailerLink");
        }
    }
}
