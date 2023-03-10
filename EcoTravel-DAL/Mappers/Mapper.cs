using EcoTravel_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoTravel_DAL.Mappers
{
    static class Mapper
    {
        public static Client ToClient(this IDataRecord record)
        {
            if (record is null) return null;
            return new Client()
            {
                idClient = (int)record[nameof(Client.idClient)],
                nom = (string)record[nameof(Client.nom)],
                prenom = (string)record[nameof(Client.prenom)],
                email = (string)record[nameof(Client.email)],
                pays = (string)record[nameof(Client.pays)],
                telephone = (string)record[nameof(Client.telephone)],
                password = "********",

            };
        }

        public static Proprietaire ToProprietaire(this IDataRecord record)
        {
            if (record is null) return null;
            return new Proprietaire()
            {
                idProprietaire = (int)record[nameof(Proprietaire.idProprietaire)],
                nom = (string)record[nameof(Proprietaire.nom)],
                prenom = (string)record[nameof(Proprietaire.prenom)],
                email = (string)record[nameof(Proprietaire.email)],
                pays = (string)record[nameof(Proprietaire.pays)],
                telephone = (string)record[nameof(Proprietaire.telephone)],
                password = "********",

            };
        }


        public static Logement ToLogement(this IDataRecord record)
        {
            if (record is null) return null;
            return new Logement()
            {
                idLogement = (int)record[nameof(Logement.idLogement)],
                nom = (string)record[nameof(Logement.nom)],
                rue = (string)record[nameof(Logement.rue)],
                numero = (string)record[nameof(Logement.numero)],
                codePostal = (string)record[nameof(Logement.codePostal)],
                pays = (string)record[nameof(Logement.codePostal)],
                latitude = (decimal)record[nameof(Logement.latitude)],
                longitude = (decimal)record[nameof(Logement.longitude)],
                descriptionCourte = (string)record[nameof(Logement.descriptionCourte)],
                descriptionLongue = (string)record[nameof(Logement.descriptionLongue)],
                nbChambre = (int)record[nameof(Logement.nbChambre)],
                nbPiece = (int)record[nameof(Logement.nbPiece)],
                prixNuit = (decimal)record[nameof(Logement.prixNuit)], 
                capacite = (int)record[nameof(Logement.capacite)],
                salleDeBain = (int)record[nameof(Logement.salleDeBain)],
                WC = (int)record[nameof(Logement.WC)],
                balcon = (bool)record[nameof(Logement.balcon)],
                airCo = (bool)record[nameof(Logement.airCo)],
                wifi = (bool)record[nameof(Logement.wifi)],
                miniBar = (bool)record[nameof(Logement.miniBar)],
                animauxAdmis = (bool)record[nameof(Logement.animauxAdmis)],
                piscine = (bool)record[nameof(Logement.piscine)],
                voiturier = (bool)record[nameof(Logement.voiturier)],
                roomService = (bool)record[nameof(Logement.roomService)],
                idType = (int)record[nameof(Logement.idType)],
                idProprietaire = (int)record[nameof(Logement.idProprietaire)],
                dateCreation = (DateTime)record[nameof(Logement.dateCreation)],
               
                

            };
        }
    }
}
