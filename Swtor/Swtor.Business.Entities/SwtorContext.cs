using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Swtor.Business.Entities
{
    public class SwtorContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Text> Texts { get; set; }

        public SwtorContext() : base("Swtor") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
        }
    }
}
