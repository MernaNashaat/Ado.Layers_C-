using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_RoleProject.SL
{
   public  class RoleAttribute:Attribute
    {
        Role role;
        public RoleAttribute(Role role)
        {
            this.role = role;
        }
        internal Role Role { get => role; set => role = value; }
    }
}
