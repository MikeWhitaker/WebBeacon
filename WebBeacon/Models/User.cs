using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace WebBeacon.Models
{

        public class User {

            [Required(ErrorMessage = "Je naam opgeven is verplicht.")]
            public string Name { get => name; set => name = value; }

            [HiddenInput(DisplayValue = false)]
            public string PasswordHash { get => passwordHash; set => passwordHash = value; }

            [Required(ErrorMessage = "Je email adres opgeven is verplicht.")]
            [RegularExpression(".+\\@.+\\..+",
            ErrorMessage = "Geef je email adres op in een geldig format.")]
            public string Email { get => email; set => email = value; }

            [HiddenInput(DisplayValue = false)]
            public int Id { get => id; set => id = value; }

            private string name;
            private string passwordHash;
            private string email;
            private int id;
        }
}

