using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public partial class Site
    {
        [Key]
        public int SiteID { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
        public int EntiteID { get; set; }
        public virtual Entite entite { get; set; }

    }
}
