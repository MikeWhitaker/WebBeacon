using System;
using System.Collections.Generic;
using System.Text;

namespace WebBeacon.Models
{
    public class IpAddress
    {

        public string Ipaddress { get => ipaddress; set => ipaddress = value; }
        public int ID { get => iD; set => iD = value; }


        private int iD;
        private string ipaddress;
    }
}
