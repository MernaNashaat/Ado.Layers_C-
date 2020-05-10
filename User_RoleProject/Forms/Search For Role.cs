using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_RoleProject.SL;

namespace User_RoleProject
{
    public partial class Search_For_Role : Form
    {
        public Search_For_Role()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm s = new StartForm();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int role_id = Int32.Parse(Role_Id.Text);
            DataRow role_Dr=RoleSL.GetById(role_id);
            Entities.Role role = RoleSL.GetRole(role_Dr);
            Result.Text = string.Format("Role Id : {0} \nRole Name : {1}", role.Id, role.Role_Name);


        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }

        private void Search_For_Role_Load(object sender, EventArgs e)
        {

        }
    }
}
