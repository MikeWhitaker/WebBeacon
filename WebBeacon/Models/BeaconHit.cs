using System;
using System.Collections.Generic;
using System.Text;

namespace WebBeacon.Models {

    class BeaconHit{

        public int Id { get => id; set => id = value; }
        public Beacon Beacon { get => beacon; set => beacon = value; }
        public int HitCount { get => hitCount; set => hitCount = value; }
        public IpAddress BeaconHitFromIp { get => beaconHitFromIp; set => beaconHitFromIp = value; }
        public DateTime OccuranceDT { get => occuranceDT; set => occuranceDT = value; }


        private int id;
        private Beacon beacon;
        private IpAddress beaconHitFromIp;
        private int hitCount;
        private DateTime occuranceDT;

    }
}
