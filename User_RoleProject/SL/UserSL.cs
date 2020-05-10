using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.BLL;
using User_RoleProject.Entities;

namespace User_RoleProject.SL
{
     static public class UserSL
    {
        public static List<User> GetAllBind()
        {
            DataTable dt = UserBLL.GetAll();
            List<User> UsersList = GenericConvertDataTableToList.ConvertDataTable<User>(dt);
            return UsersList;
        }
        public static DataTable GetAll()
        {
            return UserBLL.GetAll();
        }
        public static DataRow GetById(int id)
        {
            return UserBLL.GetById(id);
        }
        static public int Add(string user_name, string email, string password,int role_id)
        {
            return UserBLL.Add(user_name, email, password,role_id);
        }
        static public int Update(int id, string name)
        {
            return UserBLL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return UserBLL.Delete(id);
        }
        static public User GetUser(DataRow UserDr)
        {
            return UserBLL.GetUser(UserDr);
        }

       
    }
}
