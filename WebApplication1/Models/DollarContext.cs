using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication1.Models
{
    public partial class DollarContext : DbContext
    {
        public DollarContext()
            : base("name=DollarContext")
        {
        }

        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<post> posts { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
