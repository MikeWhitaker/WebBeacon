using System;
using System.Collections.Generic;
using System.Text;

namespace WebBeacon.Models
{
    public class Beacon {


        public int Id { get => id; set => id = value; }
        public User CreatedByUser { get => createdByUser; set => createdByUser = value; }
        public string BeaconGuid { get => beaconGuid; set => beaconGuid = value; }
        public string BeaconName { get => beaconName; set => beaconName = value; }




        private int id;
        private User createdByUser;
        private string beaconGuid;
        private string beaconName;


    }
}
