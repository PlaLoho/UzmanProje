using System;
using System.Collections.Generic;
using System.Text;
using UzmanLaundry.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace UzmanLaundry.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Islem> Islem { get; set; }

        public DbSet<Musteriler> Musteriler { get; set; }
    }
}
