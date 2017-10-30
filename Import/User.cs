using System;
using System.Collections.Generic;
using System.Text;

namespace WebBeacon.Models
{
    class User
    {
        public string FirstName { get => firstName; set => firstName = value; }
        public string SirName { get => sirName; set => sirName = value; }

        private string firstName;
        private string sirName;
    }
}
