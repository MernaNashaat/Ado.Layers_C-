using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.DBL;

namespace User_RoleProject.DAL
{
   static public class UserDAL
    {
        static public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt = DBL.DBL.ExcuteQuery("select * from [User]");
            return dt;
        }
        static public DataRow GetById(int id)
        {
            DataTable dt = new DataTable();
            dt = DBL.DBL.ExcuteQuery(string.Format("select * from [User] where Id={0}", id));
            return dt.Rows[0];
        }
        static public int Add(string user_name,string email,string password,int role_id)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("insert into [User] values('{0}','{1}','{2}',{3});select @@IDENTITY ", user_name,email,password,role_id));
            return result;
            
        }
        static public int Update(int id, string name)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("update [User] set Name='{0}' where Id={1}", name, id));
            return result;
        }
        static public int Delete(int id)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("delete from [User] where Id={0}", id));
            return result;
        }
       
    }
}
