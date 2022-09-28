namespace Entity_Framework_Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "name", c => c.String(maxLength: 196));
            AlterColumn("dbo.Students", "image", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "image", c => c.String());
            AlterColumn("dbo.Students", "name", c => c.String());
        }
    }
}
