using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebBeacon.Infrastucture;

namespace WebBeacon.Models
{
    public class ShowBeaconHitViewModel
    {
        public List<BeaconHit> BeaconHitList { get => beaconHitList; set => beaconHitList = value; }
        public User LoggedInuser { get => loggedInuser; set => loggedInuser = value; }

        private User loggedInuser;
        private List<BeaconHit> beaconHitList = new List<BeaconHit>();

    }
}
