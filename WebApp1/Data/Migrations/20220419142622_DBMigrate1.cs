using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp1.Data.Migrations
{
    public partial class DBMigrate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

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

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers");

            migrationBuilder.RenameTable(
                name: "AspNetUsers",
                newName: "Utilisateur");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Utilisateur",
                newName: "UtilisateurID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_SiteID",
                table: "Utilisateur",
                newName: "IX_Utilisateur_SiteID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_ProfilID",
                table: "Utilisateur",
                newName: "IX_Utilisateur_ProfilID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_imageUtilisateurImageID",
                table: "Utilisateur",
                newName: "IX_Utilisateur_imageUtilisateurImageID");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUsers_EntiteID",
                table: "Utilisateur",
                newName: "IX_Utilisateur_EntiteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur",
                column: "UtilisateurID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_Utilisateur_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "Utilisateur",
                principalColumn: "UtilisateurID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_Utilisateur_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "Utilisateur",
                principalColumn: "UtilisateurID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_Utilisateur_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "Utilisateur",
                principalColumn: "UtilisateurID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_Utilisateur_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "Utilisateur",
                principalColumn: "UtilisateurID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Entite_EntiteID",
                table: "Utilisateur",
                column: "EntiteID",
                principalTable: "Entite",
                principalColumn: "EntiteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_ImageUtilisateur_imageUtilisateurImageID",
                table: "Utilisateur",
                column: "imageUtilisateurImageID",
                principalTable: "ImageUtilisateur",
                principalColumn: "ImageID");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Profil_ProfilID",
                table: "Utilisateur",
                column: "ProfilID",
                principalTable: "Profil",
                principalColumn: "ProfilID");

            migrationBuilder.AddForeignKey(
                name: "FK_Utilisateur_Site_SiteID",
                table: "Utilisateur",
                column: "SiteID",
                principalTable: "Site",
                principalColumn: "SiteID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_Utilisateur_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_Utilisateur_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_Utilisateur_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_Utilisateur_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Entite_EntiteID",
                table: "Utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_ImageUtilisateur_imageUtilisateurImageID",
                table: "Utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Profil_ProfilID",
                table: "Utilisateur");

            migrationBuilder.DropForeignKey(
                name: "FK_Utilisateur_Site_SiteID",
                table: "Utilisateur");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Utilisateur",
                table: "Utilisateur");

            migrationBuilder.RenameTable(
                name: "Utilisateur",
                newName: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "UtilisateurID",
                table: "AspNetUsers",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateur_SiteID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_SiteID");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateur_ProfilID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_ProfilID");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateur_imageUtilisateurImageID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_imageUtilisateurImageID");

            migrationBuilder.RenameIndex(
                name: "IX_Utilisateur_EntiteID",
                table: "AspNetUsers",
                newName: "IX_AspNetUsers_EntiteID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUsers",
                table: "AspNetUsers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
