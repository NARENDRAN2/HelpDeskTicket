using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDeskTicket.Data.Migrations
{
    public partial class TicketsStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Employee_Id",
                table: "Tickets");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Employee_Id",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: true);

        }
    }
}
