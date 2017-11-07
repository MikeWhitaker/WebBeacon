using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using WebBeacon.Models;
using WebBeacon.Infrastructure;

namespace WebBeacon.Controllers
{
    public class RegisterWebBeaconHitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Hit(string BeaconGuidFromRequest) {


            using (var db = new BeaconContext()) {

                Beacon AccessedBeacon = db.Beacons.FirstOrDefault(s => s.BeaconGuid == BeaconGuidFromRequest);

                if (AccessedBeacon != null) {

                    var image = System.IO.File.OpenRead("wwwroot/images/beaconTransParent.png");
                    //db.BeaconHits.Add(new BeaconHit { Id = 1, Beacon = AccessedBeacon, BeaconHitFromIp = new IpAddress { Ipaddress = "127.0.0.1" }, OccuranceDT = DateTime.Now });

                    var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;


                    //    ServerVariables["HTTP_X_FORWARDED_FOR"];
                    //if (string.IsNullOrEmpty(ipAddress)) {
                    //    ipAddress = Request.ServerVariables["REMOTE_ADDR"];
                    //}




                    db.BeaconHits.Add(new BeaconHit { Beacon = AccessedBeacon, BeaconHitFromIp = new IpAddress { Ipaddress = ipAddress.MapToIPv4().ToString() }, OccuranceDT = DateTime.Now });
                    db.SaveChanges();

                    return File(image, "image/jpeg");

                } else {

                    return NotFound();

                }


            }
            



            //return View();
        }
    }
}