using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebBeacon.Infrastructure;
using WebBeacon.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebBeacon.Controllers
{
    [Authorize]
    public class MyBeaconsController : Controller
    {
        

        // GET: MyBeacons
        public async Task<IActionResult> Index()
        {
            //Todo: Hier moet de logica komen om asynchronus van de reeds ingelogd (omdat de user ingelogd moet zijn) user de lijst met beacons op te vragen.
            
            //return View(await _context.Users.ToListAsync());
            using (var db = new BeaconContext()) {

                var loggedInUserName = HttpContext.User.Identity.Name;
                User logedInUser = db.Users.FirstOrDefault(s => s.Email == loggedInUserName);

                if (loggedInUserName != null) {

                    View(loggedInUserName);

                } else {
                    throw new NotImplementedException();
                }


            }

            return View();
        }

        // GET: MyBeacons/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var user = await _context.Users;
                var user = new User();
                //.SingleOrDefaultAsync(m => m.Id == id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: MyBeacons/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyBeacons/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,PasswordHash,Email,Id")] User user)
        {
            if (ModelState.IsValid)
            {
                //_context.Add(user);
                //await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: MyBeacons/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
            //if (user == null)
            //{
            //    return NotFound();
            //}
            //return View(user);
        //}

        // POST: MyBeacons/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Name,PasswordHash,Email,Id")] User user)
        {
            if (id != user.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                //try
                //{
                //    _context.Update(user);
                //    await _context.SaveChangesAsync();
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!UserExists(user.Id))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
                //}
                //return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: MyBeacons/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
            //if (id == null)
            //{
            //    return NotFound();
            //}

            //var user = await _context.Users
            //    .SingleOrDefaultAsync(m => m.Id == id);
            //if (user == null)
            //{
            //    return NotFound();
            //}

            //return View(user);
        //}

        // POST: MyBeacons/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var user = await _context.Users.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.Users.Remove(user);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool UserExists(int id)
        //{
        //    return _context.Users.Any(e => e.Id == id);
        //}
    }
}
