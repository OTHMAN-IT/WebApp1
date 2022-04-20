using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public partial class Entite
    {
        [Key]
        public int EntiteID { get; set; }

        public string Libelle { get; set; }

        public DateTime DateCreation { get; set; }

        public string? Description { get; set; }

        public bool Statut { get; set; }


    }
}
