namespace WebReViewFood.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UPDATE : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ReviewFoods", "DanhGiaFood", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ReviewFoods", "DanhGiaFood", c => c.String(nullable: false));
        }
    }
}
