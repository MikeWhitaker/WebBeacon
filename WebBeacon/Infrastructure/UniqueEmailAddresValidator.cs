using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using WebBeacon.Models;
using WebBeacon.Infrastructure;

namespace WebBeacon.Infrastructure {

    public class UniqueEmailAddresValidator : Attribute, IModelValidator {

        public bool IsRequired => true;
        public string ErrorMessage { get; set; } = "Email addres is allready used to register an account.";

        public IEnumerable<ModelValidationResult> Validate(ModelValidationContext context) {

            using (var db = new BeaconContext()) {

                string value = context.Model as string;
                if (db.Users.FirstOrDefault(s => s.Email == value) != null) {
                    return new List<ModelValidationResult> {
                    new ModelValidationResult("", ErrorMessage)
                };
                } else {
                    return Enumerable.Empty<ModelValidationResult>();
                }

            }

        }
    }
}
