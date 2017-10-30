using System;
using System.Collections.Generic;
using System.Text;

namespace WebBeacon.Models
{
    public class IpAddress
    {

        public string Ipadress { get => ipadress; set => ipadress = value; }
        public string OccuranceDT { get => occuranceDT; set => occuranceDT = value; }

        
        //public DateTime OccuranceDT;
        private string occuranceDT;
        private string ipadress;
    }
}
