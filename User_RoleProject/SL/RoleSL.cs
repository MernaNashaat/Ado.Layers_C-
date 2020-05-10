using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.BLL;

namespace User_RoleProject.SL
{
    public static class RoleSL
    {
        static public List<Entities.Role> GetAllBind()
        {
            DataTable dt = RoleBLL.GetAll();
            List<Entities.Role> RoleList = GenericConvertDataTableToList.ConvertDataTable<Entities.Role>(dt);
            return RoleList;
        }
        static public DataTable GetAll()
        {
            return RoleBLL.GetAll();
        }

        static public DataRow GetById(int id)
        {
            return RoleBLL.GetById(id);
        }
        static public int Add(string role_name)
        {
            return RoleBLL.Add(role_name);
        }
        static public int Update(int id, string name)
        {
            return RoleBLL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return RoleBLL.Delete(id);
        }
        static public Entities.Role GetRole(DataRow role)
        {
            return RoleBLL.GetRole(role);
        }
    }
}
