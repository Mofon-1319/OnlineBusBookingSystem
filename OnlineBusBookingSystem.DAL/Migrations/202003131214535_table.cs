namespace OnlineBusBookingSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class table : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BusSchedules", "BusId", "dbo.Buses");
            DropIndex("dbo.BusSchedules", new[] { "BusId" });
            AddColumn("dbo.Buses", "BusType", c => c.String());
            AddColumn("dbo.Buses", "Source", c => c.String());
            AddColumn("dbo.Buses", "Destinationn", c => c.String());
            AddColumn("dbo.Buses", "Arrival", c => c.DateTime(nullable: false));
            AddColumn("dbo.Buses", "Departure", c => c.DateTime(nullable: false));
            DropTable("dbo.BusSchedules");
            AlterStoredProcedure(
                "dbo.Bus_Insert",
                p => new
                    {
                        BusNo = p.String(),
                        BusType = p.String(),
                        Source = p.String(),
                        Destinationn = p.String(),
                        Arrival = p.DateTime(),
                        Departure = p.DateTime(),
                        TotalSeat = p.Int(),
                        AvailableSeat = p.Int(),
                        BookedSeat = p.Int(),
                        Rate = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Buses]([BusNo], [BusType], [Source], [Destinationn], [Arrival], [Departure], [TotalSeat], [AvailableSeat], [BookedSeat], [Rate])
                      VALUES (@BusNo, @BusType, @Source, @Destinationn, @Arrival, @Departure, @TotalSeat, @AvailableSeat, @BookedSeat, @Rate)
                      
                      DECLARE @BusId int
                      SELECT @BusId = [BusId]
                      FROM [dbo].[Buses]
                      WHERE @@ROWCOUNT > 0 AND [BusId] = scope_identity()
                      
                      SELECT t0.[BusId]
                      FROM [dbo].[Buses] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[BusId] = @BusId"
            );
            
            AlterStoredProcedure(
                "dbo.Bus_Update",
                p => new
                    {
                        BusId = p.Int(),
                        BusNo = p.String(),
                        BusType = p.String(),
                        Source = p.String(),
                        Destinationn = p.String(),
                        Arrival = p.DateTime(),
                        Departure = p.DateTime(),
                        TotalSeat = p.Int(),
                        AvailableSeat = p.Int(),
                        BookedSeat = p.Int(),
                        Rate = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Buses]
                      SET [BusNo] = @BusNo, [BusType] = @BusType, [Source] = @Source, [Destinationn] = @Destinationn, [Arrival] = @Arrival, [Departure] = @Departure, [TotalSeat] = @TotalSeat, [AvailableSeat] = @AvailableSeat, [BookedSeat] = @BookedSeat, [Rate] = @Rate
                      WHERE ([BusId] = @BusId)"
            );
            
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BusSchedules",
                c => new
                    {
                        ScheduleId = c.Int(nullable: false, identity: true),
                        Source = c.String(),
                        Destinationn = c.String(),
                        Arrival = c.DateTime(nullable: false),
                        Departure = c.DateTime(nullable: false),
                        BusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ScheduleId);
            
            DropColumn("dbo.Buses", "Departure");
            DropColumn("dbo.Buses", "Arrival");
            DropColumn("dbo.Buses", "Destinationn");
            DropColumn("dbo.Buses", "Source");
            DropColumn("dbo.Buses", "BusType");
            CreateIndex("dbo.BusSchedules", "BusId");
            AddForeignKey("dbo.BusSchedules", "BusId", "dbo.Buses", "BusId", cascadeDelete: true);
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
