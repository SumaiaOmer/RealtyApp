using Microsoft.EntityFrameworkCore;
using RealtyWebApplication.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealtyWebApplication.EF
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Realty> Realties { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
