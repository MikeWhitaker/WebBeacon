using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using WebBeacon.Infrastructure;


namespace WebBeacon.Models {
    public class RegisterViewModel {

        private string name;
        private string email;
        private string password;
        private string passwordrepeat;

        [Required(ErrorMessage = "Je naam opgeven is verplicht.")]
        [StringLength(4)]

        public string Name { get => name; set => name = value; }

        [Required(ErrorMessage = "Je email adres opgeven is verplicht.")]
        [UniqueEmailAddresValidator]
        public string Email { get => email; set => email = value; }

        [Required(ErrorMessage = "Je paswoord opgeven is verplicht.")]
        [Compare("PasswordRepeat")]
        [StringLength(4)]
        [DataType(DataType.Password)]
        public string Password { get => password; set => password = value; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Je paswoord opgeven is verplicht.")]
        public string PasswordRepeat { get => passwordrepeat; set => passwordrepeat = value; }




    }
}
