using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_RoleProject.Entities
{
    public class Role
    {
		
		private int id;

		public List<User> Users { get; set; }
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		private string name;

		public string Role_Name
		{
			get { return name; }
			set { name = value; }
		}

		public Role(int id, string name)
		{
			this.id = id;
			this.name = name;
		}
		public Role()
		{

		}
	} 
}
