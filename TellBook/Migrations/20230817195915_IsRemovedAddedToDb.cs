using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TellBook.Migrations
{
    /// <inheritdoc />
    public partial class IsRemovedAddedToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRemoved",
                table: "ContactBook",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRemoved",
                table: "ContactBook");
        }
    }
}
