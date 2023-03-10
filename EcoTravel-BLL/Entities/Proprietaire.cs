using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_BLL.Entities
{
    public class Proprietaire:IProprietaire
    {
        public int idProprietaire { get; set; }
        public string nom { get; set; }

        //nvarchar(50)
        public string prenom { get; set; }

        //char(2)
        public string pays { get; set; }

        //nvarchar(255)
        public string email { get; set; }

        //nvarchar(20)
        public string telephone { get; set; }

        

        //varbinary(32)
        public string password { get; set; }

        //obtenir liste des logements
        public IEnumerable<Logement> Logement { get; set; }
    }
}
