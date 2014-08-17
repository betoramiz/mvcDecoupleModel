namespace DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departamen",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        departamentName = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        firstName = c.String(),
                        lastName = c.String(),
                        birthDate = c.Int(nullable: false),
                        phone = c.String(),
                        Departamen_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Departamen", t => t.Departamen_id)
                .Index(t => t.Departamen_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Employees", "Departamen_id", "dbo.Departamen");
            DropIndex("dbo.Employees", new[] { "Departamen_id" });
            DropTable("dbo.Employees");
            DropTable("dbo.Departamen");
        }
    }
}
