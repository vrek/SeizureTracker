using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeizureTrackerAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "childData",
                table: "PersonModels",
                newName: "ChildData");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChildData",
                table: "PersonModels",
                newName: "childData");
        }
    }
}
