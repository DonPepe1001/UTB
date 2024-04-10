namespace UTB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bots",
                c => new
                    {
                        botId = c.Int(nullable: false, identity: true),
                        botName = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.botId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        categoryId = c.Int(nullable: false, identity: true),
                        category = c.String(),
                        description = c.String(),
                    })
                .PrimaryKey(t => t.categoryId);
            
            CreateTable(
                "dbo.ChatSessions",
                c => new
                    {
                        chatSessionId = c.Int(nullable: false, identity: true),
                        sessionDate = c.DateTime(nullable: false),
                        startTime = c.Time(nullable: false, precision: 7),
                        endTime = c.Time(nullable: false, precision: 7),
                        chatCategory = c.String(),
                        result = c.String(),
                    })
                .PrimaryKey(t => t.chatSessionId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        messageId = c.Int(nullable: false, identity: true),
                        messageDate = c.DateTime(nullable: false),
                        content = c.String(),
                        category = c.String(),
                    })
                .PrimaryKey(t => t.messageId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        userId = c.Int(nullable: false, identity: true),
                        username = c.String(),
                        password = c.String(),
                        email = c.String(),
                    })
                .PrimaryKey(t => t.userId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Messages");
            DropTable("dbo.ChatSessions");
            DropTable("dbo.Categories");
            DropTable("dbo.Bots");
        }
    }
}
