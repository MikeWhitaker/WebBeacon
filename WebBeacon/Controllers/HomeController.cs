using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBeacon.Models;
using WebBeacon.Infrastucture;
using Microsoft.EntityFrameworkCore;

namespace WebBeacon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact(){

            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult ShowBeaconHits() {

            using (var db = new BeaconContext()) {

                ShowBeaconHitViewModel showViewModel = new ShowBeaconHitViewModel();
                showViewModel.BeaconHitList.AddRange(db.BeaconHits.Include(s => s.BeaconHitFromIp).ToList<BeaconHit>());
                showViewModel.LoggedInuser = db.Users.FirstOrDefault();

                return View(showViewModel);
            }
        }

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
