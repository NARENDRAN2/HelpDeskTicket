using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDeskTicket.Data.Migrations
{
    public partial class TicketsNameandId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Employee_Name",
                table: "Tickets");

            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EmployeeName",
                table: "Tickets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EmployeeName",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "Employee_Name",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
