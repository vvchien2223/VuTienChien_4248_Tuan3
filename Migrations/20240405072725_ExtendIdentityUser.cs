using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VuTienChien_4248_Tuan3.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<String>(
                name: "Address",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
            migrationBuilder.AddColumn<String>(
                name: "Age",
                table: "AspNetUsers",
                type: "nvarcahr(max",
                nullable: true);
            migrationBuilder.AddColumn<String>(
                name: "FullName",
                table: "AspNetUser",
                type: "navarchar(max)",
                nullable:false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
