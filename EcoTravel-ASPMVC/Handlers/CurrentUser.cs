using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_ASPMVC.Handlers
{
    public class CurrentUser
    {
        public int idUser { get; set; }

        public string email { get; set; }

        public DateTime lastConnection { get; set; }

        //bool pour savoir s'il est client ou propriétaire???? -> afficher des fonctionnalités différentes

    }
}
