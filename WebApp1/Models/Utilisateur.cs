using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public partial class Utilisateur : IdentityUser
    {

        [Required]
        [MinLength(5), MaxLength(100)]
        [Display(Name = "Nom Complet")]
        public string NomComplet { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreation { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? DateDerniereConnexion { get; set; }
        public string Statut { get; set; }

        public int? SiteID { get; set; }
        public virtual Site? site { get; set; }

        public int? EntiteID { get; set; }
        public virtual Entite? entite { get; set; }

        public int? ProfilID { get; set; }
        public virtual Profil? profil { get; set; }

        public int? ImageID { get; set; }
        public virtual ImageUtilisateur? image { get; set; }

        public string? Description { get; set; }
        public bool CompteVerrouille { get; set; }
        public string Login { get; set; }


    }
}
