using EcoTravel_Common.Repositories;
using EcoTravel_DAL.Entities;
using EcoTravel_DAL.Mappers;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Services
{
    public class ProprietaireService : BaseService, IProprietaireRepository<Proprietaire, int>
    {
        public ProprietaireService(IConfiguration config) : base(config, "EcoTravelDB")
        {

        }
        public int? CheckPassword(string email, string password)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SP_ClientCheck";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("password", password);

                    cnx.Open();

                    object result = command.ExecuteScalar();
                    return (result is DBNull) ? null : (int?)result;
                }
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Proprietaire> Get()
        {
            throw new NotImplementedException();
        }

        public Proprietaire Get(int id)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = @"SELECT [idProprietaire], [nom], [prenom], [pays], [telephone], [email], [password] 
                        FROM [Proprietaire] 
                        JOIN [Client] 
                        ON [Client].[idClient] = [Proprietaire].[idProprietaire]
                        WHERE [idProprietaire] = @id";
                    command.Parameters.AddWithValue("id", id);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToProprietaire();
                        }
                        return null;
                    }
                }
            }
        }
        public int Insert(Proprietaire entity)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    //inserer la valeur de l'idclient dans l'idProprietaire
                    command.CommandText = @"INSERT INTO [Proprietaire] ([idProprietaire]) VALUES (@idClient)";

                    command.Parameters.AddWithValue("idClient", entity.idProprietaire);

                    cnx.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Proprietaire entity)
        {
            throw new NotImplementedException();
        }
    }
}
