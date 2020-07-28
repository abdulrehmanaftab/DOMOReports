using Microsoft.EntityFrameworkCore.Migrations;

namespace ProgrammaticFiltering.Migrations
{
    public partial class migrationlatest1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "dashboard_embed_id",
                table: "ClientDashboards",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "dashboard_embed_id",
                table: "ClientDashboards");
        }
    }
}
