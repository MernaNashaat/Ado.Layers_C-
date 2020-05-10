using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.DBL;


namespace User_RoleProject.DAL
{
   static class RoleDAL
    {
        static public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt = DBL.DBL.ExcuteQuery("select * from [Role]");
            return dt;
        }
        static public DataRow GetById(int id)
        {
            DataTable dt = new DataTable();
            dt = DBL.DBL.ExcuteQuery(string.Format("select * from [Role] where Id={0}", id));
            return dt.Rows[0];
        }
        static public int Add(string role_name)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("insert into [Role] values('{0}');select @@IDENTITY ", role_name));
            return result;
        }
        static public int Update(int id , string name)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("update [Role] set Role_Name='{0}' where Id={1}", name, id));
            return result;
        }
        static public int Delete(int id)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("delete from [Role] where Id={0}", id));
            return result;
        }
    }
}
