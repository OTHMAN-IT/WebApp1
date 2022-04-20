using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class DBMigrate3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_ImageUtilisateur_imageUtilisateurImageID",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_imageUtilisateurImageID",
                table: "Utilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ImageUtilisateur",
                table: "ImageUtilisateur");

            migrationBuilder.DropColumn(
                name: "imageUtilisateurImageID",
                table: "Utilisateur");

            migrationBuilder.RenameTable(
                name: "ImageUtilisateur",
                newName: "Image");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Image",
                table: "Image",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_ImageID",
                table: "Utilisateur",
                column: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Image_ImageID",
                table: "Utilisateur",
                column: "ImageID",
                principalTable: "Image",
                principalColumn: "ImageID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Image_ImageID",
                table: "Utilisateur");

            migrationBuilder.DropIndex(
                name: "IX_Utilisateur_ImageID",
                table: "Utilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Image",
                table: "Image");

            migrationBuilder.RenameTable(
                name: "Image",
                newName: "ImageUtilisateur");

            migrationBuilder.AddColumn<int>(
                name: "imageUtilisateurImageID",
                table: "Utilisateur",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ImageUtilisateur",
                table: "ImageUtilisateur",
                column: "ImageID");

            migrationBuilder.CreateIndex(
                name: "IX_Utilisateur_imageUtilisateurImageID",
                table: "Utilisateur",
                column: "imageUtilisateurImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_ImageUtilisateur_imageUtilisateurImageID",
                table: "Utilisateur",
                column: "imageUtilisateurImageID",
                principalTable: "ImageUtilisateur",
                principalColumn: "ImageID");
        }
    }
}
