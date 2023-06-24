namespace PassWraith.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PasswraithEntity : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.credential",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_name = c.String(),
                        encrypted_password = c.String(),
                        website_name = c.String(nullable: false),
                        website_url = c.String(),
                        website_icon_url = c.String(),
                        card_number = c.String(),
                        pin = c.String(),
                        card_expiry_date = c.DateTime(),
                        note = c.String(),
                        favourite = c.Boolean(nullable: false),
                        delete = c.Boolean(nullable: false),
                        credential_type = c.Int(nullable: false),
                        deleted_date = c.DateTime(),
                        creation_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.credential");
        }
    }
}
