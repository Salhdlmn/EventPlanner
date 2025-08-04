namespace AIEventPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Events", "Title", c => c.String());
            AlterColumn("dbo.Events", "StartDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Events", "StartDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Events", "Title", c => c.String(nullable: false));
        }
    }
}
