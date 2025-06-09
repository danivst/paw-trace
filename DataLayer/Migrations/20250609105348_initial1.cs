using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataLayer.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LocationId1",
                table: "LostAnimals",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LocationId1",
                table: "FoundAnimals",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LostAnimals_LocationId1",
                table: "LostAnimals",
                column: "LocationId1");

            migrationBuilder.CreateIndex(
                name: "IX_FoundAnimals_LocationId1",
                table: "FoundAnimals",
                column: "LocationId1");

            migrationBuilder.AddForeignKey(
                name: "FK_FoundAnimals_Locations_LocationId1",
                table: "FoundAnimals",
                column: "LocationId1",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_LostAnimals_Locations_LocationId1",
                table: "LostAnimals",
                column: "LocationId1",
                principalTable: "Locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoundAnimals_Locations_LocationId1",
                table: "FoundAnimals");

            migrationBuilder.DropForeignKey(
                name: "FK_LostAnimals_Locations_LocationId1",
                table: "LostAnimals");

            migrationBuilder.DropIndex(
                name: "IX_LostAnimals_LocationId1",
                table: "LostAnimals");

            migrationBuilder.DropIndex(
                name: "IX_FoundAnimals_LocationId1",
                table: "FoundAnimals");

            migrationBuilder.DropColumn(
                name: "LocationId1",
                table: "LostAnimals");

            migrationBuilder.DropColumn(
                name: "LocationId1",
                table: "FoundAnimals");
        }
    }
}
