using EcoTravel_ASPMVC.Models.ClientViewModel;
using EcoTravel_BLL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_ASPMVC.Handlers
{
    public static class Mapper
    {
        public static ClientListItem ToListItem(this Client entity)
        {
            if (entity is null) return null;
            return new ClientListItem()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email=entity.email,
                pays=entity.pays,
                telephone=entity.telephone

            };
        }

        public static Client ToBLL(this ClientCreateForm entity)
        {
            if (entity is null) return null;
            return new Client()
            {
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays=entity.pays,
                telephone=entity.telephone,
                password = entity.password
            };
        }

        public static ClientDetails ToDetails(this Client entity)
        {
            if (entity is null) return null;
            return new ClientDetails()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays = entity.pays,
                telephone = entity.telephone,

            };
        }
    }
}
