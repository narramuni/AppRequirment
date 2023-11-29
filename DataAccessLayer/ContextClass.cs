using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ContextClass : DbContext
    {
        public DbSet<EmpProfile> EmpProfiles { get; set; }
        public DbSet<DeptMaster> DeptMasters { get; set; }

        public ContextClass() : base("name=Model1")
        {
            Database.SetInitializer<ContextClass>(new CreateDatabaseIfNotExists<ContextClass>());
            this.Configuration.ProxyCreationEnabled = false;
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
