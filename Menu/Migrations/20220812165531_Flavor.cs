using Microsoft.EntityFrameworkCore.Migrations;

namespace Menu.Migrations
{
    public partial class Flavor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_Categories_FlavorId",
                table: "TreatFlavor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Flavors");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_Flavors_FlavorId",
                table: "TreatFlavor",
                column: "FlavorId",
                principalTable: "Flavors",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavor_Flavors_FlavorId",
                table: "TreatFlavor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flavors",
                table: "Flavors");

            migrationBuilder.RenameTable(
                name: "Flavors",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "FlavorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavor_Categories_FlavorId",
                table: "TreatFlavor",
                column: "FlavorId",
                principalTable: "Categories",
                principalColumn: "FlavorId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
