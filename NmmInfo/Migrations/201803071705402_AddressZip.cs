namespace NmmInfo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddressZip : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Breweries", "Address", c => c.String());
            AddColumn("dbo.Breweries", "Zip", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Breweries", "Zip");
            DropColumn("dbo.Breweries", "Address");
        }
    }
}
