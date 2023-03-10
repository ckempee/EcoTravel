using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    //utile: créer, modifier et avoir les détails de chaque clients
    //Eventuellement, plus tard obtenir une liste de tous les clients pour chaque propriétaire
    public interface IClientRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IClient
    {
        int? CheckPassword(string email, string password);

        //Afficher une liste de tous les clients d'un propriétaire? 
    }
    
}
