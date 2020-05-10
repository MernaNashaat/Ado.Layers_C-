using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_RoleProject.Entities
{
   public class City
    {
        public City()
        {

        }
        private int id;
        private string city_name;
        private Country country;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string City_Name
        {
            get { return city_name; }
            set { city_name = value; }
        }

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }




    }
}
