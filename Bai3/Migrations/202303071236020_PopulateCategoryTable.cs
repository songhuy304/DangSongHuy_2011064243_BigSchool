namespace Bai3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (1,'DEVELO')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (2,'DESIGNT')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (3,'FRONT')");
            Sql("INSERT INTO CATEGORIES (ID,NAME) VALUES (4,'BACK')");
        }
        
        public override void Down()
        {
        }
    }
}
