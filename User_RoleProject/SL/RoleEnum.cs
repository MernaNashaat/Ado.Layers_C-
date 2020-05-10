 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_RoleProject.SL
{
    [Flags]
   public enum Role
    {
        Admin=1,
        Instructor=2,
        Student=4,
        Supervisor=8,
        Employee=16
    }
}
