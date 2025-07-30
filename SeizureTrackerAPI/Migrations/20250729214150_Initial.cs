using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeizureTrackerAPI.Migrations;

/// <inheritdoc />
public partial class Initial : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        _ = migrationBuilder.CreateTable(
            name: "PersonModels",
            columns: table => new
            {
                PersonID = table.Column<Guid>(type: "TEXT", nullable: false),
                PersonType = table.Column<int>(type: "INTEGER", nullable: false),
                FirstName = table.Column<string>(type: "TEXT", nullable: false),
                LastName = table.Column<string>(type: "TEXT", nullable: false),
                DateOfBirth = table.Column<DateOnly>(type: "TEXT", nullable: false),
                childData = table.Column<string>(type: "TEXT", nullable: true)
            },
            constraints: table =>
            {
                _ = table.PrimaryKey("PK_PersonModels", x => x.PersonID);
            });

        _ = migrationBuilder.CreateTable(
            name: "Seizures",
            columns: table => new
            {
                SeizureEventId = table.Column<Guid>(type: "TEXT", nullable: false),
                SeizureDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                SeizureSeverity = table.Column<int>(type: "INTEGER", nullable: false),
                SeizureDurationMinutes = table.Column<float>(type: "REAL", nullable: false),
                SeizureComments = table.Column<string>(type: "TEXT", maxLength: 5000, nullable: true),
                Patient = table.Column<Guid>(type: "TEXT", nullable: false)
            },
            constraints: table =>
            {
                _ = table.PrimaryKey("PK_Seizures", x => x.SeizureEventId);
            });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        _ = migrationBuilder.DropTable(
            name: "PersonModels");

        _ = migrationBuilder.DropTable(
            name: "Seizures");
    }
}
