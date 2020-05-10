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
    static public class UserBLL
    {
        static public List<User> GetAllBind()
        {
             DataTable dt = UserDAL.GetAll();
            List<User> UsersList=GenericConvertDataTableToList.ConvertDataTable<User>(dt);
            return UsersList;
        }
        static public DataTable GetAll()
        {
            return UserDAL.GetAll();
        }
        static public DataRow GetById(int id)
        {
           return  UserDAL.GetById(id);
        }
        static public int Add(string user_name, string email,string password,int role_id)
        {
            return UserDAL.Add(user_name, email,password, role_id);
        }
        static public int Update(int id, string name)
        {
            return UserDAL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return UserDAL.Delete(id);
        }
        static public User GetUser(DataRow UserDr)
        {
            User user = new User();
            user.Id = UserDr.Field<int>("Id");
            user.Name = UserDr.Field<string>("Name");
            user.Email = UserDr.Field<string>("Email");
            user.Password = UserDr.Field<string>("Password");
            user.Role_Id = UserDr.Field<int>("Role_Id");
            return user;
        }
    }
}
