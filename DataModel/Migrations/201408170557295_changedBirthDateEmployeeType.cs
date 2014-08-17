namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedBirthDateEmployeeType : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Employees", "birthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Employees", "birthDate", c => c.Int(nullable: false));
        }
    }
}
