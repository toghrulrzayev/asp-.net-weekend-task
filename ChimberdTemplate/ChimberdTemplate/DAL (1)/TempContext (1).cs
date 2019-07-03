using ChimberdTemplate.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace ChimberdTemplate.DAL
{
    public class TempContext : DbContext
    {
        public TempContext() : base("TempCn")
        {

        }
        public DbSet<Aboutus> About { get; set; }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<FirstSlider> Slider { get; set; }
        public DbSet<Projects> Project { get; set; }
        public DbSet<Services> Service { get; set; }
        public DbSet<Settings> Setting { get; set; }
        public DbSet<Testimonials> testimonial { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<Translate> Translates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}