using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Entities
{
    public class Avis
    {
        public int idAvis { get; set; }
        public int idLogement { get; set; }

        public int idReservation { get; set; }
        public int note { get; set; }
        public string description {get; set;}

    }
}
