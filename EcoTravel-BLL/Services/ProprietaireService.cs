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
    public class ProprietaireService : IProprietaireRepository<Proprietaire, int>
    {
        private readonly IProprietaireRepository<EcoTravel_DAL.Entities.Proprietaire, int> _repository;
        private readonly ILogementRepository<EcoTravel_DAL.Entities.Logement, int> _log_repository;

        public ProprietaireService(IProprietaireRepository<EcoTravel_DAL.Entities.Proprietaire, int> repository, ILogementRepository<EcoTravel_DAL.Entities.Logement, int> log_repository)
        {
            _repository = repository;
            _log_repository = log_repository;
        }

        //liste des logements

        public int? CheckPassword(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }

        public IEnumerable<Proprietaire> Get()
        {
            return _repository.Get().Select(e => e.ToBLL());
        }

        public Proprietaire Get(int id)
        {
            Proprietaire entity = _repository.Get(id).ToBLL();
            entity.Logement = _log_repository.GetByProprietaire(id).Select(e => e.ToBLL());
            return entity;
        }

        public int Insert(Proprietaire entity)
        {
            return _repository.Insert(entity.ToDAL());
        }

        public bool Update(int id, Proprietaire entity)
        {
            return _repository.Update(id, entity.ToDAL());
        }
    }
}
