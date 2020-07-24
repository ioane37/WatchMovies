namespace WatchMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Changes : DbMigration
    {
        public override void Up()
        {
            RenameTable("dbo.Movis", "dbo.Movies");
        }
        
        public override void Down()
        {
            
        }
    }
}
