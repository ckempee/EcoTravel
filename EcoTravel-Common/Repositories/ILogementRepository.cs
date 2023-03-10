using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
   public interface ILogementRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : ILogement
    {
        //affiche une liste de tous les logements par proprietaire:
        IEnumerable<TEntity> GetByProprietaire(int idProprietaire);

        //afficher tous les logements selon un type de logement
        IEnumerable<TEntity> GetByType(int idType);
    }
}
