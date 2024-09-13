using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Students_Affaires.Migrations
{
    /// <inheritdoc />
    public partial class DBStudent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageStudent",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageStudent",
                table: "Students");
        }
    }
}
