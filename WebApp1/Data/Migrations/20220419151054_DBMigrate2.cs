using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class DBMigrate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "EmailIndex",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "ConcurrencyStamp",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "NormalizedEmail",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "NormalizedUserName",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "PhoneNumberConfirmed",
                table: "Utilisateur");

            migrationBuilder.DropColumn(
                name: "TwoFactorEnabled",
                table: "Utilisateur");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ConcurrencyStamp",
                table: "Utilisateur",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedEmail",
                table: "Utilisateur",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NormalizedUserName",
                table: "Utilisateur",
                type: "nvarchar(256)",
                maxLength: 256,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Utilisateur",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PhoneNumberConfirmed",
                table: "Utilisateur",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TwoFactorEnabled",
                table: "Utilisateur",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Utilisateur",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Utilisateur",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }
    }
}
