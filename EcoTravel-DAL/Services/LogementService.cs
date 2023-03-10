using EcoTravel_DAL.Entities;
using EcoTravel_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using EcoTravel_DAL.Mappers;

namespace EcoTravel_DAL.Services
{
    public class LogementService : BaseService, ILogementRepository<Logement, int>
    {
        public LogementService(IConfiguration config) : base(config, "EcoTravelDB")
        {

        }
        public bool Delete(int id)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "DELETE FROM [Logement] WHERE [idLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    cnx.Open();
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public IEnumerable<Logement> Get()
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Logement]";
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public Logement Get(int id)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = "SELECT * FROM [Logement] WHERE [idLogement] = @id";
                    command.Parameters.AddWithValue("id", id);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.ToLogement();
                        }
                        return null;
                    }
                }
            }
        }

        public IEnumerable<Logement> GetByProprietaire(int idProprietaire)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    //récupérer tous les logements dont l'idpropriétaire du logement=idProprietaire de proprietaire
                    command.CommandText = "SELECT * FROM [Logement] WHERE [idProprietaire] = @id";
                    command.Parameters.AddWithValue("id", idProprietaire);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }

        public IEnumerable<Logement> GetByType(int idType)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    //récupérer tous les logements dont l'idtype du logement=idType dy type souhaité
                    command.CommandText = "SELECT * FROM [Logement] WHERE [idType] = @id";
                    command.Parameters.AddWithValue("id", idType);
                    cnx.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            yield return reader.ToLogement();
                        }
                    }
                }
            }
        }


        public int Insert(Logement entity)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Logement] ([idLogement], [nom], [rue], 
                    [numero], [codePostal], [pays], [latitude], [longitude], [descriptionCourte], [descriptionLongue],
                    [nbChambre], [nbPiece], [prixNuit], [capacite], [salleDeBain], [WC],
                    [balcon], [airCo], [wifi], [miniBar], [animauxAdmis],
                    [piscine], [voiturier], [roomService], [idType], [idProprietaire], [dateCreation]) 
                    VALUES (@idLogement, @nom, @rue, @numero, @codePostal, @pays, @latitude, @longitude
                    @descriptionLongue, @descriptionLongue, @nbChambre, @nbPiece, @prixNuit, @capacite, @salleDeBain, @WC,
                    @balcon, @airCo, @wifi, @minibar, @animauxAdmis, @piscine, @voiturier,
                    @roomService,@idType, @idProprietaire, @dateCreation)";

                    command.Parameters.AddWithValue("idLogement", entity.idLogement);
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("rue", entity.rue);
                    command.Parameters.AddWithValue("numero", entity.numero);
                    command.Parameters.AddWithValue("codePostal", entity.codePostal);
                    command.Parameters.AddWithValue("pays", entity.pays);
                    command.Parameters.AddWithValue("longitude", entity.longitude);
                    command.Parameters.AddWithValue("latitude", entity.latitude);
                    command.Parameters.AddWithValue("descriptionCourte", entity.descriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.descriptionLongue);
                    command.Parameters.AddWithValue("nbChambre", entity.nbChambre);
                    command.Parameters.AddWithValue("nbPiece", entity.nbPiece);
                    command.Parameters.AddWithValue("prixNuit", entity.prixNuit);
                    command.Parameters.AddWithValue("capacite", entity.capacite);
                    command.Parameters.AddWithValue("salleDeBain", entity.salleDeBain);
                    command.Parameters.AddWithValue("WC", entity.WC);
                    command.Parameters.AddWithValue("balcon", entity.balcon);
                    command.Parameters.AddWithValue("airCo", entity.airCo);
                    command.Parameters.AddWithValue("wifi", entity.wifi);
                    command.Parameters.AddWithValue("miniBar", entity.miniBar);
                    command.Parameters.AddWithValue("animauxAdmis", entity.animauxAdmis);
                    command.Parameters.AddWithValue("piscine", entity.piscine);
                    command.Parameters.AddWithValue("voiturier", entity.voiturier);
                    command.Parameters.AddWithValue("roomService", entity.roomService);
                    command.Parameters.AddWithValue("idType", entity.idType);
                    command.Parameters.AddWithValue("idProprietaire", entity.idProprietaire);
                    command.Parameters.AddWithValue("dateCreation", entity.dateCreation);

                    cnx.Open();

                    return (int)command.ExecuteScalar();
                }
            }
        }

        public bool Update(int id, Logement entity)
        {
            using (SqlConnection cnx = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = cnx.CreateCommand())
                {
                    command.CommandText = @"INSERT INTO [Logement] ([idLogement], [nom], [rue], 
                    [numero], [codePostal], [pays], [latitude], [longitude], [descriptionCourte], [descriptionLongue],
                    [nbChambre], [nbPiece], [prixNuit], [capacite], [salleDeBain], [WC],
                    [balcon], [airCo], [wifi], [miniBar], [animauxAdmis],
                    [piscine], [voiturier], [roomService], [idType], [idProprietaire], [dateCreation]) 
                    VALUES (@idLogement, @nom, @rue, @numero, @codePostal, @pays, @latitude, @longitude
                    @descriptionLongue, @descriptionLongue, @nbChambre, @nbPiece, @prixNuit, @capacite, @salleDeBain, @WC,
                    @balcon, @airCo, @wifi, @minibar, @animauxAdmis, @piscine, @voiturier,
                    @roomService,@idType, @idProprietaire, @dateCreation)";

                    command.Parameters.AddWithValue("idLogement", entity.idLogement);
                    command.Parameters.AddWithValue("nom", entity.nom);
                    command.Parameters.AddWithValue("rue", entity.rue);
                    command.Parameters.AddWithValue("numero", entity.numero);
                    command.Parameters.AddWithValue("codePostal", entity.codePostal);
                    command.Parameters.AddWithValue("pays", entity.pays);
                    command.Parameters.AddWithValue("longitude", entity.longitude);
                    command.Parameters.AddWithValue("latitude", entity.latitude);
                    command.Parameters.AddWithValue("descriptionCourte", entity.descriptionCourte);
                    command.Parameters.AddWithValue("descriptionLongue", entity.descriptionLongue);
                    command.Parameters.AddWithValue("nbChambre", entity.nbChambre);
                    command.Parameters.AddWithValue("nbPiece", entity.nbPiece);
                    command.Parameters.AddWithValue("prixNuit", entity.prixNuit);
                    command.Parameters.AddWithValue("capacite", entity.capacite);
                    command.Parameters.AddWithValue("salleDeBain", entity.salleDeBain);
                    command.Parameters.AddWithValue("WC", entity.WC);
                    command.Parameters.AddWithValue("balcon", entity.balcon);
                    command.Parameters.AddWithValue("airCo", entity.airCo);
                    command.Parameters.AddWithValue("wifi", entity.wifi);
                    command.Parameters.AddWithValue("miniBar", entity.miniBar);
                    command.Parameters.AddWithValue("animauxAdmis", entity.animauxAdmis);
                    command.Parameters.AddWithValue("piscine", entity.piscine);
                    command.Parameters.AddWithValue("voiturier", entity.voiturier);
                    command.Parameters.AddWithValue("roomService", entity.roomService);
                    command.Parameters.AddWithValue("idType", entity.idType);
                    command.Parameters.AddWithValue("idProprietaire", entity.idProprietaire);
                    command.Parameters.AddWithValue("dateCreation", entity.dateCreation);

                    cnx.Open();

                    return command.ExecuteNonQuery() > 0;
                }
            }
            }
    }
}
