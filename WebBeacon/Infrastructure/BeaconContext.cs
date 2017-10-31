using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using WebBeacon.Models;

namespace WebBeacon.Infrastucture
{
    public class BeaconContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<IpAddress> IpAddresses { get; set; }
        public DbSet<Beacon> Beacons { get; set; }
        public DbSet<BeaconHit> BeaconHits { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlite("Data Source=Beacon.db");
        }

    }
}
