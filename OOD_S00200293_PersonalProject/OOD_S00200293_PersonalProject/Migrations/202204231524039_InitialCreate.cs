namespace OOD_S00200293_PersonalProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        MovieID = c.String(nullable: false, maxLength: 128),
                        Title = c.String(),
                        Year = c.String(),
                        ImbdRating = c.String(),
                        Poster = c.String(),
                        Plot = c.String(),
                        Rated = c.String(),
                        Director = c.String(),
                    })
                .PrimaryKey(t => t.MovieID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
