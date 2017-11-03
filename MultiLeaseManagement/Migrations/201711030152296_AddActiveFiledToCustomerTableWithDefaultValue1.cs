namespace MultiLeaseManagement.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddActiveFiledToCustomerTableWithDefaultValue1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Active", c => c.Boolean(nullable: false,defaultValue:true));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Active");
        }
    }
}
