using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_ASPMVC.Models.ClientViewModel
{
    public class ClientCreateForm
    {
        [Required(ErrorMessage = "Le nom est requis")]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom de famille :")]
        public string nom { get; set; }

        [Required(ErrorMessage = "Le prénom est requis")]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Prénom :")]
        public string prenom { get; set; }

        [Required(ErrorMessage = "L'email est requis")]
        [MaxLength(255)]
        [MinLength(5)]
        [EmailAddress]
        [DisplayName("Email :")]
        public string email { get; set; }


        [Required]
        [MaxLength(50)]
        [MinLength(1)]
   
        [DisplayName("Pays :")]
        public string pays { get; set; }

        [Required(ErrorMessage = "Le télléphone est requis")]
        [MaxLength(50)]
        [MinLength(10)]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("Telephone :")]
        public string telephone { get; set; }


        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe : ")]
        public string password { get; set; }
        [Required]
        [MaxLength(32)]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare(nameof(password))]
        [DisplayName("Confirmez le mot de passe : ")]
        public string repassword { get; set; }

    }
}
