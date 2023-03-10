using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_ASPMVC.Models.LogementViewModel
{
    public class LogementCreateForm
    {
        [DisplayName("Identitfiant")]
        [ScaffoldColumn(false)]
        public int id_Proprietaire { get; set; }


        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Nom :")]
        public string nom { get; set; }



        [Required]
        [MaxLength(16)]
        [MinLength(1)]
        [DisplayName("Rue :")]
        public string rue { get; set; }

        [Required]
        [MaxLength(16)]
        [MinLength(1)]
        [DisplayName("Numero :")]
        public string numero { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DataType(DataType.PostalCode)]
        [DisplayName("Code Postal :")]
        public string codePostal { get; set; }


        [Required]
        [MaxLength(50)]
        [MinLength(1)]
        [DisplayName("Pays :")]
        public string pays { get; set; }

        [Required]
        [Range(-180, 180)]
        [DisplayName("Latitude:")]
        public decimal latitude { get; set; }


        [Required]
        [Range(-180, 180)]
        [DisplayName("Longitude:")]
        public decimal longitude { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(8)]
        [DisplayName("Description courte :")]
        public string descriptionCourte { get; set; }
        [Required]
        [MaxLength(1000)]
        [MinLength(1)]
        [DisplayName("Description Longue :")]
        public string descriptionLongue { get; set; }

        [Required]
        [DisplayName("Nombre de chambre :")]
        public int nbChambre { get; set; }


        [Required]
        [DisplayName("Nombre de piece :")]
        public int nbPiece { get; set; }



        [Required]
        [DataType(DataType.Currency)]
        [DisplayName("Prix/nuit :")]
        public decimal prixNuit { get; set; }
        

        [Required]
        [DisplayName("Capacite de personne(s) :")]
        public int capacite { get; set; }


        [Required]
        
        [DisplayName("Nombre de salle de Bain :")]
        public int salleDeBain { get; set; }

        [Required]
        [DisplayName("Nombre de WC :")]
        public int WC { get; set; }

        [Required]
        [DisplayName("Balcon :")]
        
        public bool balcon { get; set; }
        [Required]
        [DisplayName("Air Conditionné :")]
        public bool airCo { get; set; }
        [Required]
        [DisplayName("Wifi :")]
        public bool wifi { get; set; }
        [Required]
        [DisplayName("Mini Bar :")]
        public bool miniBar { get; set; }
        [Required]
        [DisplayName("Autorisé aux animaux:")]
        public bool animauxAdmis { get; set; }
        [Required]
        [DisplayName("Piscine :")]
        public bool piscine { get; set; }
        [Required]
        [DisplayName("Voiturier :")]
        public bool voiturier { get; set; }
        [Required]
        [DisplayName("RoomService :")]
        public bool roomService { get; set; }
        
        [ScaffoldColumn(false)]
        public int idCategorie { get; set; }
        [ScaffoldColumn(false)]
        public int idProprietaire { get; set; }

        [ScaffoldColumn(false)]
        public DateTime dateCreation { get; set; }
    }
}
