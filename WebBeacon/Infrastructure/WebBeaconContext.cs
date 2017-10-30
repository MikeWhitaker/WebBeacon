using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebBeacon.Models;

namespace WebBeacon.Infrastucture
{
    class WebBeaconContext : DbContext
    {

        DbSet<User> Users;
        DbSet<IpAddress> IpAddresses;
        DbSet<WebBeacon.Models.WebBeacon> WebBeacons;


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=WebBeacon.db");
        }

    }
}
