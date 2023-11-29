using Data.ClothShoppingSite.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.ClothShoppingSite.DbContext
{
    public class ApplicationDbContext: IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        { }
        
        public DbSet<CssProduct> products { get; set; }
        public DbSet<CssGeneral> generals { get; set; }
        public DbSet<CssGallery> galleries  { get; set; }
        public DbSet<CssKind> kinds { get; set; }
        public DbSet<CssVariant> variants { get; set; }
        public DbSet<CssWeight> weights { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<tCustomer>().ToTable("Customer");
            base.OnModelCreating(modelBuilder);
            // modelBuilder.Seed();
        }
    }
}
