using EcoTravel_Common.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_Common.Repositories
{
    public interface IProprietaire<TEntity, TId> : IRepository<TEntity, TId> where TEntity : IProprietaire
    {
        int? CheckPassword(string email, string password);
    }
    
}
