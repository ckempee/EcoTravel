using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL = EcoTravel_BLL.Entities;
using DAL = EcoTravel_DAL.Entities;

namespace EcoTravel_BLL.Mappers
{
    static class Mapper
    {
        #region Client
        public static BLL.Client ToBLL(this DAL.Client entity)
        {
            if (entity is null) return null;
            return new BLL.Client()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays = entity.pays,
                telephone = entity.telephone,
                password = entity.password
            };
        }

        public static DAL.Client ToDAL(this BLL.Client entity)
        {
            if (entity is null) return null;
            return new DAL.Client()
            {
                idClient = entity.idClient,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays = entity.pays,
                telephone = entity.telephone,
                password = entity.password

            };
        }

        #endregion

        #region Proprietaire
        public static BLL.Proprietaire ToBLL(this DAL.Proprietaire entity)
        {
            if (entity is null) return null;
            return new BLL.Proprietaire()
            {
                idProprietaire = entity.idProprietaire,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays = entity.pays,
                telephone = entity.telephone,
                password = entity.password
            };
        }

        public static DAL.Proprietaire ToDAL(this BLL.Proprietaire entity)
        {
            if (entity is null) return null;
            return new DAL.Proprietaire()
            {
                idProprietaire = entity.idProprietaire,
                nom = entity.nom,
                prenom = entity.prenom,
                email = entity.email,
                pays = entity.pays,
                telephone = entity.telephone,
                password = entity.password

            };
        }

        #endregion

        #region Logement

        public static BLL.Logement ToBLL(this DAL.Logement entity)
        {
            if (entity is null) return null;
            return new BLL.Logement()
            {
                idLogement = entity.idLogement,
                nom = entity.nom,
                rue = entity.rue,
                numero = entity.numero,
                codePostal = entity.codePostal,
                pays = entity.pays,
                latitude = entity.latitude,
                longitude = entity.longitude,
                descriptionCourte = entity.descriptionCourte,
                descriptionLongue = entity.descriptionLongue,
                nbChambre = entity.nbChambre,
                nbPiece = entity.nbPiece,
                prixNuit = entity.prixNuit,
                capacite = entity.capacite,
                salleDeBain = entity.salleDeBain,
                WC = entity.WC,
                balcon = entity.balcon,
                airCo = entity.airCo,
                wifi = entity.wifi,
                miniBar = entity.miniBar,
                animauxAdmis = entity.animauxAdmis,
                piscine = entity.piscine,
                voiturier = entity.voiturier,
                roomService = entity.roomService,
                idType = entity.idType,
                idProprietaire = entity.idProprietaire,
                proprietaire = null,
                type=null,
                dateCreation=entity.dateCreation
                
               
               
            };
        }

        public static DAL.Logement ToDAL(this BLL.Logement entity)
        {
            if (entity is null) return null;
            return new DAL.Logement()
            {
                idLogement = entity.idLogement,
                nom = entity.nom,
                rue = entity.rue,
                numero = entity.numero,
                codePostal = entity.codePostal,
                pays = entity.pays,
                latitude = entity.latitude,
                longitude = entity.longitude,
                descriptionCourte = entity.descriptionCourte,
                descriptionLongue = entity.descriptionLongue,
                nbChambre = entity.nbChambre,
                nbPiece = entity.nbPiece,
                prixNuit = entity.prixNuit,
                capacite = entity.capacite,
                salleDeBain = entity.salleDeBain,
                WC = entity.WC,
                balcon = entity.balcon,
                airCo = entity.airCo,
                wifi = entity.wifi,
                miniBar = entity.miniBar,
                animauxAdmis = entity.animauxAdmis,
                piscine = entity.piscine,
                voiturier = entity.voiturier,
                roomService = entity.roomService,
                idType = entity.idType,
                idProprietaire = entity.idProprietaire,
               
                dateCreation = entity.dateCreation
            };
        }

        #endregion

    }
}


