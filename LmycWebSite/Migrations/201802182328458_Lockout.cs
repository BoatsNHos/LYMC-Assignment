namespace LmycWebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lockout : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "LockoutEnabled", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "LockoutEnabled", c => c.Boolean());
        }
    }
}
