namespace Wakency.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserDetails : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "fname", c => c.String());
            AddColumn("dbo.AspNetUsers", "lname", c => c.String());
            AddColumn("dbo.AspNetUsers", "email", c => c.String());
            AddColumn("dbo.AspNetUsers", "contact", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "contact");
            DropColumn("dbo.AspNetUsers", "email");
            DropColumn("dbo.AspNetUsers", "lname");
            DropColumn("dbo.AspNetUsers", "fname");
        }
    }
}
