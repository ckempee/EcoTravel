using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IReservationRepository<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IReservation
    {

        //afficher toutes les réservations d'un client
        
        IEnumerable<TEntity> GetByClient(int idClient);
        //afficher toutes les réservations d'un proprietaire
        IEnumerable<TEntity> GetByProprietaire(int idProprietaire);
    }
}
