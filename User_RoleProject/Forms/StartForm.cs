using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_RoleProject.SL;

namespace User_RoleProject
{
    public partial class StartForm : Form
    {
        List<Entities.Role> Roles;
        public StartForm()
        {
            InitializeComponent();
            Roles = RoleSL.GetAllBind();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regestration r = new Regestration();

            button1.BackColor = Color.DarkRed;
            button1.ForeColor = Color.White;
            
            this.Hide();
            r.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Countries_Cities c = new Countries_Cities();
            if(Regestration.CurrentUser!=null)
            {
                button1.BackColor = Color.DarkRed;
                button1.ForeColor = Color.White;
                this.Hide();
                c.Show();
            }
            else
            {
                MessageBox.Show("You Should regester or login first");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddRole role = new AddRole();
            if (Regestration.CurrentUser != null)
            {
            
                if (CheckIfAdmin())
                {
                    this.Hide();
                    role.Show();
                }
                else
                {
                    MessageBox.Show("This functionality is available for Admins only");
                }


            }
            else
            {
                MessageBox.Show("You Should regester or login first");
            }

        }
        private bool CheckIfAdmin()
        {
            int userRoleId = Regestration.CurrentUser.Role_Id;
            int admin_role = (int)Role.Admin;
            Entities.Role AdminRole = RoleSL.GetRole(RoleSL.GetById(admin_role));
            Entities.Role UserRole = RoleSL.GetRole(RoleSL.GetById(userRoleId));

            string AdminRole_name = Regestration.SplitSpaces(AdminRole.Role_Name);
            string userRole_name = Regestration.SplitSpaces(UserRole.Role_Name);
            if(AdminRole_name==userRole_name)
            {
                return true;
            }
            return false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Search_For_Role S_role = new Search_For_Role();

           if(Regestration.CurrentUser != null)
            {
               
                if (CheckIfAdmin())
                {
                    this.Hide();
                    S_role.Show();
                }
                else
                {
                    MessageBox.Show("This functionality is available for Admins only");
                }
            }
              else
            {
                MessageBox.Show("You Should regester or login first");
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
