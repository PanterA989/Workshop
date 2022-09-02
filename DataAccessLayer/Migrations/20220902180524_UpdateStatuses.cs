using Microsoft.EntityFrameworkCore.Migrations;

namespace Workshop.DataAccessLayer.Migrations
{
    public partial class UpdateStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "WorkshopTaskStatuses",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StatusGroupNumber",
                table: "WorkshopTaskStatuses",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusGroupNumberOrder",
                table: "WorkshopTaskStatuses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "WorkshopTaskStatuses");

            migrationBuilder.DropColumn(
                name: "StatusGroupNumber",
                table: "WorkshopTaskStatuses");

            migrationBuilder.DropColumn(
                name: "StatusGroupNumberOrder",
                table: "WorkshopTaskStatuses");
        }
    }
}
