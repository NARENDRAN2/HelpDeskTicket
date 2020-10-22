using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpDeskTicket.Data.Migrations
{
    public partial class TicketsTableAttachmentProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttachmentExtension",
                table: "Tickets",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AttachmentName",
                table: "Tickets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentExtension",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "AttachmentName",
                table: "Tickets");
        }
    }
}
