using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Students_Affaires.Migrations
{
    /// <inheritdoc />
    public partial class DB3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnrollmentDate",
                table: "Enrollment");

            migrationBuilder.DropColumn(
                name: "EnrollmentID",
                table: "Enrollment");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EnrollmentDate",
                table: "Enrollment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EnrollmentID",
                table: "Enrollment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
