using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_RoleProject.DAL;
using User_RoleProject.Entities;
using User_RoleProject.SL;

namespace User_RoleProject.BLL
{
    static public  class CityBLL
    {
        static public List<City> GetAllBind()
        {
            DataTable dt = CityDAL.GetAll();
            List<City> CitiesList = GenericConvertDataTableToList.ConvertDataTable<City>(dt);
            return CitiesList;
        }
        static public DataTable GetAll()
        {
            return CityDAL.GetAll();
        }

       
        [Role(SL.Role.Admin)]
        static public DataRow GetById(int id)
        {
            return CityDAL.GetById(id);
        }
        static public int Add(string country_name)
        {
            return CityDAL.Add(country_name);
        }
        static public int Update(int id, string name)
        {
            return CityDAL.Update(id, name);
        }
        static public int Delete(int id)
        {
            return CityDAL.Delete(id);
        }
    }
}
