using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = EcoTravel_BLL.Entities;
using DAL = EcoTravel_DAL.Entities;

namespace EcoTravel_BLL.Mappers
{
    static class Mapper
    {
        public static BLL.Client ToBLL(this DAL.Client entity)
        {
            if (entity is null) return null;
            return new BLL.Client()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays = entity.pays,
                telephone = entity.telephone,
                password = entity.password
            };
        }

        public static DAL.Client ToDAL(this BLL.Client entity)
        {
            if (entity is null) return null;
            return new DAL.Client()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays = entity.pays,
                telephone = entity.telephone,
                password = entity.password

            };
        }
    }
}
