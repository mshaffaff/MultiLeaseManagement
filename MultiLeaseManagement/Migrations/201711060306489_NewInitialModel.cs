namespace MultiLeaseManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewInitialModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Leases", "Active", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Leases", "Active");
        }
    }
}
