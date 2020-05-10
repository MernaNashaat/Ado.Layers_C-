using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.BLL;
using User_RoleProject.DAL;
using User_RoleProject.Entities;

namespace User_RoleProject.SL
{
   static public class CitySl
    {
        static public List<Country> GetAllBind()
        {
            List<Country> CountriesList = new List<Country>();
            DataTable dt = CountryBLL.GetAll();
          CountriesList=  GenericConvertDataTableToList.ConvertDataTable<Country>(dt);
            return CountriesList;
          
        }
        static public DataTable GetAll()
        {
            return CountryBLL.GetAll();
        }
        static public Country GetById(int id)
        {
            Country country = null;
            Role user_role = Role.Admin;
            Type type = typeof(CountryBLL);
            MethodInfo method = type.GetMethod("GetById");
            RoleAttribute attribute = method.GetCustomAttribute<RoleAttribute>();
            Role function_role = attribute.Role;
            if (user_role == function_role)
            {
                DataRow dr= CountryBLL.GetById(id);
                country = new Country();
                
                country.ID= dr.Field<int>("ID");
                country.Country_Name = dr.Field<string>("Name");
            }
            return country;
        }
        static public int Add(string country_name)
        {
            return CountryBLL.Add(country_name);
        }
        static public int Update(int id, string name)
        {
            return CountryBLL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return CountryBLL.Delete(id);
        }

    }
}
