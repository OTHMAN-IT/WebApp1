using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class DBMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "CompteVerrouille",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreation",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateDerniereConnexion",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EntiteID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ImageID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Login",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NomComplet",
                table: "AspNetUsers",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProfilID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SiteID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Statut",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "imageUtilisateurImageID",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Entite",
                columns: table => new
                {
                    EntiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Statut = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entite", x => x.EntiteID);
                });

            migrationBuilder.CreateTable(
                name: "ImageUtilisateur",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUtilisateur", x => x.ImageID);
                });

            migrationBuilder.CreateTable(
                name: "Profil",
                columns: table => new
                {
                    ProfilID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profil", x => x.ProfilID);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    SiteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntiteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.SiteID);
                    table.ForeignKey(
                        name: "FK_Site_Entite_EntiteID",
                        column: x => x.EntiteID,
                        principalTable: "Entite",
                        principalColumn: "EntiteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EntiteID",
                table: "AspNetUsers",
                column: "EntiteID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_imageUtilisateurImageID",
                table: "AspNetUsers",
                column: "imageUtilisateurImageID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfilID",
                table: "AspNetUsers",
                column: "ProfilID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_SiteID",
                table: "AspNetUsers",
                column: "SiteID");

            migrationBuilder.CreateIndex(
                name: "IX_Site_EntiteID",
                table: "Site",
                column: "EntiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Entite_EntiteID",
                table: "AspNetUsers",
                column: "EntiteID",
                principalTable: "Entite",
                principalColumn: "EntiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_ImageUtilisateur_imageUtilisateurImageID",
                table: "AspNetUsers",
                column: "imageUtilisateurImageID",
                principalTable: "ImageUtilisateur",
                principalColumn: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Profil_ProfilID",
                table: "AspNetUsers",
                column: "ProfilID",
                principalTable: "Profil",
                principalColumn: "ProfilID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Site_SiteID",
                table: "AspNetUsers",
                column: "SiteID",
                principalTable: "Site",
                principalColumn: "SiteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Entite_EntiteID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_ImageUtilisateur_imageUtilisateurImageID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Profil_ProfilID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Site_SiteID",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ImageUtilisateur");

            migrationBuilder.DropTable(
                name: "Profil");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "Entite");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EntiteID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_imageUtilisateurImageID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProfilID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_SiteID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CompteVerrouille",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateCreation",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DateDerniereConnexion",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EntiteID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ImageID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Login",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NomComplet",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfilID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "SiteID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Statut",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "imageUtilisateurImageID",
                table: "AspNetUsers");
        }
    }
}
