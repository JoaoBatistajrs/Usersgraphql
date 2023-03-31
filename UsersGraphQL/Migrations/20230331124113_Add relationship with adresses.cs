using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsersGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class Addrelationshipwithadresses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Adresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_UserId",
                table: "Adresses",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Adresses_Users_UserId",
                table: "Adresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Adresses_Users_UserId",
                table: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Adresses_UserId",
                table: "Adresses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Adresses");
        }
    }
}
