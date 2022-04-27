namespace OOD_S00200293_PersonalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlteredIMDBRating : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "imdbRating", c => c.String());
            DropColumn("dbo.Movies", "ImbdRating");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Movies", "ImbdRating", c => c.String());
            DropColumn("dbo.Movies", "imdbRating");
        }
    }
}
