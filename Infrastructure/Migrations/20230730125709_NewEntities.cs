using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class NewEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "DoctorId",
                table: "Hospital",
                type: "uuid",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Hospital_DoctorId",
                table: "Hospital",
                type: "uuid",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Hospital_Doctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationTimestamp = table.Column<string>(type: "text", nullable: false),
                    ModifiedTimestamp = table.Column<string>(type: "text", nullable: false),
                    DeletedTimestamp = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialisation_Doctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Experience = table.Column<DateOnly>(type: "date", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationTimestamp = table.Column<string>(type: "text", nullable: false),
                    ModifiedTimestamp = table.Column<string>(type: "text", nullable: false),
                    DeletedTimestamp = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisation_Doctor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    FullDescription = table.Column<string>(type: "text", nullable: false),
                    Birthday = table.Column<DateOnly>(type: "date", nullable: false),
                    Hospital_DoctorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Specialisation_DoctorId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationTimestamp = table.Column<string>(type: "text", nullable: false),
                    ModifiedTimestamp = table.Column<string>(type: "text", nullable: false),
                    DeletedTimestamp = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_Hospital_Doctor_Hospital_DoctorId",
                        column: x => x.Hospital_DoctorId,
                        principalTable: "Hospital_Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Doctor_Specialisation_Doctor_Specialisation_DoctorId",
                        column: x => x.Specialisation_DoctorId,
                        principalTable: "Specialisation_Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Specialisation",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Specialisation_DoctorId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationTimestamp = table.Column<string>(type: "text", nullable: false),
                    ModifiedTimestamp = table.Column<string>(type: "text", nullable: false),
                    DeletedTimestamp = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialisation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Specialisation_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Specialisation_Specialisation_Doctor_Specialisation_DoctorId",
                        column: x => x.Specialisation_DoctorId,
                        principalTable: "Specialisation_Doctor",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_DoctorId",
                table: "Hospital",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_Hospital_DoctorId",
                table: "Hospital",
                column: "Hospital_DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Hospital_DoctorId",
                table: "Doctor",
                column: "Hospital_DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Specialisation_DoctorId",
                table: "Doctor",
                column: "Specialisation_DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialisation_DoctorId",
                table: "Specialisation",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialisation_Specialisation_DoctorId",
                table: "Specialisation",
                column: "Specialisation_DoctorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_Doctor_DoctorId",
                table: "Hospital",
                column: "DoctorId",
                principalTable: "Doctor",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hospital_Hospital_Doctor_Hospital_DoctorId",
                table: "Hospital",
                column: "Hospital_DoctorId",
                principalTable: "Hospital_Doctor",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hospital_Doctor_DoctorId",
                table: "Hospital");

            migrationBuilder.DropForeignKey(
                name: "FK_Hospital_Hospital_Doctor_Hospital_DoctorId",
                table: "Hospital");

            migrationBuilder.DropTable(
                name: "Specialisation");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Hospital_Doctor");

            migrationBuilder.DropTable(
                name: "Specialisation_Doctor");

            migrationBuilder.DropIndex(
                name: "IX_Hospital_DoctorId",
                table: "Hospital");

            migrationBuilder.DropIndex(
                name: "IX_Hospital_Hospital_DoctorId",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "DoctorId",
                table: "Hospital");

            migrationBuilder.DropColumn(
                name: "Hospital_DoctorId",
                table: "Hospital");
        }
    }
}
