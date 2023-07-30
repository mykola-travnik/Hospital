using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hospital_Doctor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    CreationTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                    CreationTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                name: "Hospital",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Address = table.Column<string>(type: "text", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: false),
                    CityId = table.Column<Guid>(type: "uuid", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uuid", nullable: true),
                    Hospital_DoctorId = table.Column<Guid>(type: "uuid", nullable: true),
                    IsDeleted = table.Column<bool>(type: "boolean", nullable: false),
                    CreationTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospital", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hospital_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospital_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Hospital_Hospital_Doctor_Hospital_DoctorId",
                        column: x => x.Hospital_DoctorId,
                        principalTable: "Hospital_Doctor",
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
                    CreationTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ModifiedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DeletedTimestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
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
                name: "IX_Doctor_Hospital_DoctorId",
                table: "Doctor",
                column: "Hospital_DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Specialisation_DoctorId",
                table: "Doctor",
                column: "Specialisation_DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_CityId",
                table: "Hospital",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_DoctorId",
                table: "Hospital",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospital_Hospital_DoctorId",
                table: "Hospital",
                column: "Hospital_DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialisation_DoctorId",
                table: "Specialisation",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Specialisation_Specialisation_DoctorId",
                table: "Specialisation",
                column: "Specialisation_DoctorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospital");

            migrationBuilder.DropTable(
                name: "Specialisation");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Hospital_Doctor");

            migrationBuilder.DropTable(
                name: "Specialisation_Doctor");
        }
    }
}
