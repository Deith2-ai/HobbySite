namespace Hobby.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    CreateDate = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    FirstName = c.String(nullable: false),
                    LastName = c.String(nullable: false),
                    Email = c.String(nullable: false),
                    Password = c.String(),
                    City = c.String(),
                    Avatar = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Activities",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    CreateDate = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    IdUser = c.Long(nullable: false),
                    ActivityName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser);

            CreateTable(
                "dbo.Settings",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    CreateDate = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    IdUser = c.Long(nullable: false),
                    Name = c.String(nullable: false),
                    Value = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser);

            CreateTable(
                "dbo.UserPermissions",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    CreateDate = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    IdUser = c.Long(nullable: false),
                    IdPermission = c.Long(nullable: false),
                    LastModifyDate = c.DateTime(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Permissions", t => t.IdPermission)
                .ForeignKey("dbo.Users", t => t.IdUser)
                .Index(t => t.IdUser)
                .Index(t => t.IdPermission);

            CreateTable(
                "dbo.Permissions",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    CreateDate = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    Name = c.String(nullable: false),
                    Value = c.Int(nullable: false),
                    Deleted = c.Boolean(nullable: false),
                    Description = c.String(),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Categories",
                c => new
                {
                    Id = c.Long(nullable: false, identity: true),
                    CreateDate = c.DateTime(),
                    RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "timestamp"),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }

        public override void Down()
        {
            DropForeignKey("dbo.UserPermissions", "IdUser", "dbo.Users");
            DropForeignKey("dbo.UserPermissions", "IdPermission", "dbo.Permissions");
            DropForeignKey("dbo.Settings", "IdUser", "dbo.Users");
            DropForeignKey("dbo.Activities", "IdUser", "dbo.Users");
            DropIndex("dbo.UserPermissions", new[] { "IdPermission" });
            DropIndex("dbo.UserPermissions", new[] { "IdUser" });
            DropIndex("dbo.Settings", new[] { "IdUser" });
            DropIndex("dbo.Activities", new[] { "IdUser" });
            DropTable("dbo.Categories");
            DropTable("dbo.Permissions");
            DropTable("dbo.UserPermissions");
            DropTable("dbo.Settings");
            DropTable("dbo.Activities");
            DropTable("dbo.Users");
        }
    }
}
