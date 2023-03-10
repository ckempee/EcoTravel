using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IAvisRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IAvis
    {

        //récupérer, ajouter, modifier
        //liste de tous les avis d'un logement
        IEnumerable<TEntity> GetByLogement(int idLogement);

        //liste de tous les avis d'un client: Enumerable<TEntity> GetByClient(int idClient);???
    }
}
