using System.ComponentModel.DataAnnotations;

namespace WebApp1.Models
{
    public partial class ImageUtilisateur
    {
        [Key]
        public int ImageID { get; set; }
        public string Libelle { get; set; }
        public string Image { get; set; }
    }
}
