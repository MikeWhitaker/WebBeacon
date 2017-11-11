using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebBeacon.Models
{
    public class MyBeaconViewModel {

        public List<Beacon> UsersBeacons { get => usersBeacons; set => usersBeacons = value; }
        public User LoggedInUser { get => loggedInUser; set => loggedInUser = value; }
        public BeaconHit FirstBeaconHit { get => firstBeaconHit; set => firstBeaconHit = value; }


        private User loggedInUser;
        private List<Beacon> usersBeacons;
        private BeaconHit firstBeaconHit;

    }
}
