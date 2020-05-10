using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.DAL;
using User_RoleProject.Entities;

namespace User_RoleProject.BLL
{
    static public class RoleBLL
    {
        static public List<Role> GetAllBind()
        {
            DataTable dt = RoleDAL.GetAll();
            List<Role> RoleList = GenericConvertDataTableToList.ConvertDataTable<Role>(dt);
            return RoleList;
        }
        static public DataTable GetAll()
        {
            return RoleDAL.GetAll();
        }

        static public DataRow GetById(int id)
        {
            return RoleDAL.GetById(id);
        }
        static public int Add(string role_name)
        {
            return RoleDAL.Add(role_name);
        }
        static public int Update(int id, string name)
        {
            return RoleDAL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return RoleDAL.Delete(id);
        }
        static public Entities.Role GetRole(DataRow role)
        {

            Entities.Role R = new Entities.Role();
            R.Id = role.Field<int>("Id");
            R.Role_Name = role.Field<string>("Role_Name");
            return R;
        }
    }
}
