using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeizureTrackerAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeperateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonModels");

            migrationBuilder.RenameColumn(
                name: "Patient",
                table: "Seizures",
                newName: "PatientID");

            migrationBuilder.RenameColumn(
                name: "SeizureEventId",
                table: "Seizures",
                newName: "SeizureID");

            migrationBuilder.AlterColumn<int>(
                name: "SeizureDurationMinutes",
                table: "Seizures",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "REAL");

            migrationBuilder.AlterColumn<string>(
                name: "SeizureComments",
                table: "Seizures",
                type: "TEXT",
                maxLength: 5000,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 5000,
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    PatientID = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.PatientID);
                });

            migrationBuilder.CreateTable(
                name: "Caregivers",
                columns: table => new
                {
                    CaregiverID = table.Column<Guid>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    PatientID = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caregivers", x => x.CaregiverID);
                    table.ForeignKey(
                        name: "FK_Caregivers_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID");
                });

            migrationBuilder.CreateTable(
                name: "CaregiverPatientLinks",
                columns: table => new
                {
                    LinkID = table.Column<Guid>(type: "TEXT", nullable: false),
                    CaregiverID = table.Column<Guid>(type: "TEXT", nullable: false),
                    PatientID = table.Column<Guid>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CaregiverPatientLinks", x => x.LinkID);
                    table.ForeignKey(
                        name: "FK_CaregiverPatientLinks_Caregivers_CaregiverID",
                        column: x => x.CaregiverID,
                        principalTable: "Caregivers",
                        principalColumn: "CaregiverID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CaregiverPatientLinks_Patients_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patients",
                        principalColumn: "PatientID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Seizures_PatientID",
                table: "Seizures",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_CaregiverPatientLinks_CaregiverID_PatientID",
                table: "CaregiverPatientLinks",
                columns: new[] { "CaregiverID", "PatientID" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CaregiverPatientLinks_PatientID",
                table: "CaregiverPatientLinks",
                column: "PatientID");

            migrationBuilder.CreateIndex(
                name: "IX_Caregivers_PatientID",
                table: "Caregivers",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Seizures_Patients_PatientID",
                table: "Seizures",
                column: "PatientID",
                principalTable: "Patients",
                principalColumn: "PatientID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seizures_Patients_PatientID",
                table: "Seizures");

            migrationBuilder.DropTable(
                name: "CaregiverPatientLinks");

            migrationBuilder.DropTable(
                name: "Caregivers");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Seizures_PatientID",
                table: "Seizures");

            migrationBuilder.RenameColumn(
                name: "PatientID",
                table: "Seizures",
                newName: "Patient");

            migrationBuilder.RenameColumn(
                name: "SeizureID",
                table: "Seizures",
                newName: "SeizureEventId");

            migrationBuilder.AlterColumn<float>(
                name: "SeizureDurationMinutes",
                table: "Seizures",
                type: "REAL",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<string>(
                name: "SeizureComments",
                table: "Seizures",
                type: "TEXT",
                maxLength: 5000,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 5000);

            migrationBuilder.CreateTable(
                name: "PersonModels",
                columns: table => new
                {
                    PersonID = table.Column<Guid>(type: "TEXT", nullable: false),
                    ChildData = table.Column<string>(type: "TEXT", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    PersonType = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonModels", x => x.PersonID);
                });
        }
    }
}
