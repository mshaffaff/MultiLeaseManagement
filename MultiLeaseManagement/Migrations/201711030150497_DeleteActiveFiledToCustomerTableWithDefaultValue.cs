namespace MultiLeaseManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteActiveFiledToCustomerTableWithDefaultValue : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "Active");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "Active", c => c.Boolean(nullable: false));
        }
    }
}
