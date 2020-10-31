using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDeskTicket.Data.Migrations
{
    public partial class EmployeeDeleteInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "AspNetUsers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmployeeId",
                table: "AspNetUsers",
                type: "nvarchar(14)",
                maxLength: 14,
                nullable: false,
                defaultValue: "");
        }
    }
}
