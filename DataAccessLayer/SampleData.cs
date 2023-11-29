using System.Data.Entity;

namespace DataAccessLayer
{
    public class SampleData : DropCreateDatabaseIfModelChanges<ContextClass>
    {
        protected override void Seed(ContextClass context)
        {
            
            context.EmpProfiles.Add(new EmpProfile { EmpCode = 1,  });
            context.EmpProfiles.Add(new EmpProfile { EmpCode = 2,  });

            context.DeptMasters.Add(new DeptMaster { DeptCode = 1,  });
            context.DeptMasters.Add(new DeptMaster { DeptCode = 2, / });

            context.SaveChanges();
        }
    }
}
