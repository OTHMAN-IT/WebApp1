using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public partial class Profil
    {
        [Key]
        public int ProfilID { get; set; }
        public string Libelle { get; set; }
        public DateTime DateCreation { get; set; }
    }
}
