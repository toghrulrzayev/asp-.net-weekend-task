namespace ChimberdTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcreate2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Translate",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Keyword = c.String(),
                        English = c.String(),
                        Az = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Translate");
        }
    }
}
