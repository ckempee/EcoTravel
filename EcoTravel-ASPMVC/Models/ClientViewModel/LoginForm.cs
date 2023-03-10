﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcoTravel_ASPMVC.Models.ClientViewModel
{
    public class LoginForm
    {
        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        [EmailAddress]
        [DisplayName("Adresse email:")]
        public string email { get; set; }
        [Required]
        [MinLength(8)]
        [MaxLength(32)]
        [DataType(DataType.Password)]
        [DisplayName("Mot de passe:")]
        public string password { get; set; }
    }
}
