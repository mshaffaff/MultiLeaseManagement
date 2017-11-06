namespace MultiLeaseManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActiveFiledToPaymentTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Payments", "Active", c => c.Boolean(nullable: false,defaultValue:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Payments", "Active");
        }
    }
}
