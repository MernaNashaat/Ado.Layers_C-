using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_RoleProject.DAL
{
    class CountryDAL
    {
        static public DataTable GetAll()
        {
            DataTable dt = new DataTable();
            dt = DBL.DBL.ExcuteQuery("select * from [Country]");
            return dt;
        }
        static public DataRow GetById(int id)
        {
            DataTable dt = new DataTable();
            dt = DBL.DBL.ExcuteQuery(string.Format("select * from [Country] where Id={0}", id));
            return dt.Rows[0];
        }
        static public int Add(string country_name)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("insert into [Country] values('{0}');select @@IDENTITY ",country_name));
            return result;

        }
        static public int Update(int id, string name)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("update [Country] set Name='{0}' where Id={1}", name, id));
            return result;
        }
        static public int Delete(int id)
        {
            int result;
            result = DBL.DBL.ExcuteNonQuery(string.Format("delete from [Country] where Id={0}", id));
            return result;
        }
    }
}
