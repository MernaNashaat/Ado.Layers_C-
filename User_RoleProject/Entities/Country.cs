using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_RoleProject.Entities
{
    public class Country
    {
        public Country()
        {

        }
        private int id;
        private string country_name;
        private List<City> cities;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Country_Name
        {
            get { return country_name; }
            set { country_name = value; }
        }

        public List<City> Cities
        {
            get { return cities; }
            set { cities = value; }
        }



    }
}
