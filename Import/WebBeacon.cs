using System;
using System.Collections.Generic;
using System.Text;

namespace WebBeacon.Models
{
    class WebBeacon
    {

        public IpAddress WebBeaconHitFromIp;
        public User CreatedByUser { get => createdByUser; set => createdByUser = value; }

        private User createdByUser;
        private IpAddress webbeaconHotFromIp;

    }
}
