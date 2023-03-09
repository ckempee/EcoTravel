using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    public class Annulation
    {
        public int idClient { get; set; }
        public int idReservation {get;set;}
        public DateTime dateAnnulation { get; set; }
    }
}
