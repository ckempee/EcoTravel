using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    public class Indisponibilite
    {

        public int idIndisponibilite { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public int idClient { get; set; }
        public int idLogement {get;set;}
    }
}
