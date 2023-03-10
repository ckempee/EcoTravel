using EcoTravel_BLL.Entities;
using EcoTravel_BLL.Mappers;
using EcoTravel_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_BLL.Services
{
    public class LogementService : ILogementRepository<Logement, int>

    {

        private readonly ILogementRepository<EcoTravel_DAL.Entities.Logement, int> _repository;

        public LogementService(ILogementRepository<EcoTravel_DAL.Entities.Logement, int> repository)
        {
            _repository = repository;
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Logement> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Logement Get(int id)
        {
            return _repository.Get(id).ToBLL();
        }

        public IEnumerable<Logement> GetByProprietaire(int idProprietaire)
        {
            return _repository.GetByProprietaire(idProprietaire).Select(e => e.ToBLL());
        }

        public IEnumerable<Logement> GetByType(int idType)
        {
            return _repository.GetByType(idType).Select(e => e.ToBLL());
        }

        public int Insert(Logement entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Logement entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }
    }
}
