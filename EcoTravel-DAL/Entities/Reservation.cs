using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    public class Reservation
    {
        public int idReservation { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public int nbAdultes { get; set; }
        public int nbEnfant { get; set; }
        public decimal PrixTotal { get; set; }
        public bool Assurance { get; set; }
        public bool annulerPar { get; set; }
        public int idLogement {get;set;}
        public int idClient { get; set; }
 
    }
}
