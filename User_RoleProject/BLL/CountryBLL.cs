using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.DAL;
using User_RoleProject.Entities;
using User_RoleProject.SL;
using Role = User_RoleProject.Entities.Role;

namespace User_RoleProject.BLL
{
   static public class CountryBLL
    {
        static public List<Country> GetAllBind()
        {
            DataTable dt = CountryDAL.GetAll();
            List<Country> CountriesList = GenericConvertDataTableToList.ConvertDataTable<Country>(dt);
            return CountriesList;
        }
        static public DataTable GetAll()
        {
            return CountryDAL.GetAll();
        }

        [Role(SL.Role.Admin)]
        static public DataRow GetById(int id)
        {
            return CountryDAL.GetById(id);
        }
        static public int Add(string country_name)
        {
            return CountryDAL.Add(country_name);
        }
        static public int Update(int id, string name)
        {
            return CountryDAL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return CountryDAL.Delete(id);
        }
    }
}
