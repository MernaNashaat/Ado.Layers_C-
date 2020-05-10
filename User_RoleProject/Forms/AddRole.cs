using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_RoleProject.BLL;
using User_RoleProject.SL;

namespace User_RoleProject
{
    public partial class AddRole : Form
    {
        List<Entities.Role> Roles;
        public AddRole()
        {
            InitializeComponent();
            Roles = RoleSL.GetAllBind();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AddRole_Load(object sender, EventArgs e)
        {

        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Role_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = Role_Name.Text;
            if(Role_Name.Text.Length!=0)
            {
                if(Roles.Where(r => r.Role_Name == name).ToList().Count<=0)
                {
                RoleBLL.Add(name);
                MessageBox.Show("Role Added Successfully");
                 Role_Name.Text =  " ";
                }
                else
                {
                    MessageBox.Show("Role already exist ");

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm s = new StartForm();
            s.Show();
        }
    }
}
