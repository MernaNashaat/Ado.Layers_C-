using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.BLL;
using User_RoleProject.Entities;

namespace User_RoleProject.SL
{
   public static class CitySL
    {
        static public List<City> GetAllBind()
        {
            DataTable dt = CityBLL.GetAll();
            List<City> Cities = GenericConvertDataTableToList.ConvertDataTable<City>(dt);
            return Cities;
        }
        static public DataTable GetAll()
        {
            return CityBLL.GetAll();
        }
        static public City GetById(int id , Role user_role)
        {
            City city = null;
            Type type = typeof(CityBLL);
            MethodInfo method = type.GetMethod("GetById");
            RoleAttribute attribute = method.GetCustomAttribute<RoleAttribute>();
            Role function_role = attribute.Role;
            if (user_role == function_role)
            {
                DataRow dr = CityBLL.GetById(id);
                if(dr!=null)
                {

                city = new City();
                //foreach (DataColumn c in dr.Table.Columns)
                //{
                //    var x = c.ColumnName;
                //}
                city.ID = dr.Field<int>("ID");
                city.City_Name = dr.Field<string>("City_Name");
                }
            }
            return city;
        }
        static public int Add(string country_name)
        {
            return CityBLL.Add(country_name);
        }
        static public int Update(int id, string name)
        {
            return CityBLL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return CityBLL.Delete(id);
        }
    }
}
