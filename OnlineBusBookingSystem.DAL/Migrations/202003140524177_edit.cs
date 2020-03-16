namespace OnlineBusBookingSystem.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edit : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Buses", "AvailableSeat");
            DropColumn("dbo.Buses", "BookedSeat");
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
                        Rate = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Buses]([BusNo], [BusType], [Source], [Destinationn], [Arrival], [Departure], [TotalSeat], [Rate])
                      VALUES (@BusNo, @BusType, @Source, @Destinationn, @Arrival, @Departure, @TotalSeat, @Rate)
                      
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
                        Rate = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Buses]
                      SET [BusNo] = @BusNo, [BusType] = @BusType, [Source] = @Source, [Destinationn] = @Destinationn, [Arrival] = @Arrival, [Departure] = @Departure, [TotalSeat] = @TotalSeat, [Rate] = @Rate
                      WHERE ([BusId] = @BusId)"
            );
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Buses", "BookedSeat", c => c.Int(nullable: false));
            AddColumn("dbo.Buses", "AvailableSeat", c => c.Int(nullable: false));
            throw new NotSupportedException("Scaffolding create or alter procedure operations is not supported in down methods.");
        }
    }
}
