using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class MyDatabaseInitializer : DropCreateDatabaseIfModelChanges<ContextClass>
    {
        protected override void Seed(ContextClass context)
        {
            
            context.DeptMasters.Add(new DeptMaster { DeptCode = 1, DeptName = "IT" });
            context.DeptMasters.Add(new DeptMaster { DeptCode = 2, DeptName = "HR" });

            base.Seed(context);
        }
    

    }
}
