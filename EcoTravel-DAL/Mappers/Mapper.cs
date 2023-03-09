﻿using EcoTravel_DAL.Entities;
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
    }
}
