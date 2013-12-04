namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LectureHallAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LectureHall",
                c => new
                    {
                        LectureHallID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Floor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LectureHallID);
        }
        
        public override void Down()
        {
            DropTable("dbo.LectureHall");
        }
    }
}
