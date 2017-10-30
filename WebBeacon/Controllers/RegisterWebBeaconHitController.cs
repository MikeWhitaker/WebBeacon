using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebBeacon.Models;

namespace WebBeacon.Controllers
{
    public class RegisterWebBeaconHitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Hit(Models.WebBeacon webbeacon) {
            return View();
        }
    }
}