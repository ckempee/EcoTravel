using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    class Logement
    {
        public int idLogement { get; set; }
        public string nom { get; set; }
        public string rue { get; set; }
        public string numero { get; set; }
        public string codePostal { get; set; }

        public string pays { get; set; }

        public decimal latitude { get; set; }
        public string descriptionCourte { get; set; }
        public string descriptionLongue { get; set; }

        public int nbChambre { get; set; }
        public int nbPiece { get; set; }
        public decimal prixNuit { get; set; }

        public int capacite { get; set; }

        public int salleDeBain { get; set; }
        public int WC { get; set; }

        public bool balcon { get; set; }

        public bool AirCo {get;set;}

        public bool wifi { get; set; }

        public bool miniBar { get; set; }
        public bool animauxAdmis { get; set; }

        public bool piscine { get; set; }

        public bool voiturier { get; set; }

        public bool roomService { get; set; }

        public int idType { get; set; }

        public int idClient { get; set; }

        public DateTime dateCreation { get; set; }


    }
}
