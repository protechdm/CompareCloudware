namespace CompareCloudware.POCOQueryRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColleague : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Colleagues",
                c => new
                    {
                        ColleagueID = c.Int(nullable: false, identity: true),
                        RowVersion = c.Binary(),
                        ColleagueOfIntroducer_PersonID = c.Int(),
                        Introducer_PersonID = c.Int(),
                    })
                .PrimaryKey(t => t.ColleagueID)
                .ForeignKey("dbo.Persons", t => t.ColleagueOfIntroducer_PersonID)
                .ForeignKey("dbo.Persons", t => t.Introducer_PersonID)
                .Index(t => t.ColleagueOfIntroducer_PersonID)
                .Index(t => t.Introducer_PersonID);
            
            AddColumn("dbo.CloudApplicationRequests", "RequestData", c => c.String());
            AlterColumn("dbo.Persons", "Forename", c => c.String());
            AlterColumn("dbo.Persons", "NumberOfEmployees", c => c.Int());
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Colleagues", "Introducer_PersonID", "dbo.Persons");
            DropForeignKey("dbo.Colleagues", "ColleagueOfIntroducer_PersonID", "dbo.Persons");
            DropIndex("dbo.Colleagues", new[] { "Introducer_PersonID" });
            DropIndex("dbo.Colleagues", new[] { "ColleagueOfIntroducer_PersonID" });
            AlterColumn("dbo.Persons", "NumberOfEmployees", c => c.Int(nullable: false));
            AlterColumn("dbo.Persons", "Forename", c => c.String(nullable: false));
            DropColumn("dbo.CloudApplicationRequests", "RequestData");
            DropTable("dbo.Colleagues");
        }
    }
}
