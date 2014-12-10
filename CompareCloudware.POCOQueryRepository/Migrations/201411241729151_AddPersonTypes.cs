namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonTypes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PersonTypes",
                c => new
                    {
                        PersonTypeID = c.Int(nullable: false, identity: true),
                        PersonTypeName = c.String(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                        PersonTypeStatus_StatusID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PersonTypeID)
                .ForeignKey("dbo.Statuses", t => t.PersonTypeStatus_StatusID)
                .Index(t => t.PersonTypeStatus_StatusID);
            
            AddColumn("dbo.Persons", "PersonType_PersonTypeID", c => c.Int());
            CreateIndex("dbo.Persons", "PersonType_PersonTypeID");
            AddForeignKey("dbo.Persons", "PersonType_PersonTypeID", "dbo.PersonTypes", "PersonTypeID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Persons", "PersonType_PersonTypeID", "dbo.PersonTypes");
            DropForeignKey("dbo.PersonTypes", "PersonTypeStatus_StatusID", "dbo.Statuses");
            DropIndex("dbo.PersonTypes", new[] { "PersonTypeStatus_StatusID" });
            DropIndex("dbo.Persons", new[] { "PersonType_PersonTypeID" });
            DropColumn("dbo.Persons", "PersonType_PersonTypeID");
            DropTable("dbo.PersonTypes");
        }
    }
}
