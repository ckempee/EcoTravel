using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_ASPMVC.Models.ClientViewModel
{
    public class ClientListItem
    {
        [DisplayName("Identifiant")]
        [ScaffoldColumn(false)]
        public int idClient { get; set; }
        [DisplayName("Nom de famille :")]
        public string nom { get; set; }
        [DisplayName("Prénom :")]
        public string prenom { get; set; }

        [DisplayName("Email :")]
        public string email { get; set; }

        [DisplayName("Pays :")]
        public string pays { get; set; }

        [DisplayName("Telephone :")]
        public string telephone { get; set; }
    }
}

