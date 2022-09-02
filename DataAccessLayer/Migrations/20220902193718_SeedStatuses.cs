using Microsoft.EntityFrameworkCore.Migrations;

namespace Workshop.DataAccessLayer.Migrations
{
    public partial class SeedStatuses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "WorkshopTaskStatuses",
                columns: new[] { "Id", "IsActive", "StatusGroupNumber", "StatusGroupNumberOrder", "Value" },
                values: new object[,]
                {
                    { 1, true, 0, 0, "Przyjęty" },
                    { 2, true, 0, 1, "Do odbioru" },
                    { 3, false, 0, 2, "Zrealizowany" },
                    { 4, true, 1, 0, "Anulowany - do odbioru" },
                    { 5, false, 1, 1, "Anulowany - odebrany" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WorkshopTaskStatuses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "WorkshopTaskStatuses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "WorkshopTaskStatuses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "WorkshopTaskStatuses",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "WorkshopTaskStatuses",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
