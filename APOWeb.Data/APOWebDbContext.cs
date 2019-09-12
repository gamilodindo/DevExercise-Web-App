using APOWeb.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APOWeb.Data
{
    public class APOWebDbContext : DbContext
    {
    
        public APOWebDbContext()
           : base("APOWebDbContext")
        {

        }

        public DbSet<APO> APOs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
