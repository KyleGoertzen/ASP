namespace VideoStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeTypeToNameInMembershipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MembershipTypes", "Name", c => c.String());
            DropColumn("dbo.MembershipTypes", "Type");
        }
        
        public override void Down()
        {
            AddColumn("dbo.MembershipTypes", "Type", c => c.String());
            DropColumn("dbo.MembershipTypes", "Name");
        }
    }
}
