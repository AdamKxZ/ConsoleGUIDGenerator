namespace GUIDGenerator.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DBs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        GUID = c.String(),
                        DateAdded = c.DateTimeOffset(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.DBs");
        }
    }
}
