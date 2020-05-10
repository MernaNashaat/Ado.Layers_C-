using Microsoft.SqlServer.Server;
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
using User_RoleProject.Entities;
using User_RoleProject.SL;

namespace User_RoleProject
{
    public partial class Countries_Cities : Form
    {
        public object UserBll { get; private set; }

        public Countries_Cities()
        {
            InitializeComponent();
        }

        private void Countries_Cities_Load(object sender, EventArgs e)
        {
            GetCountries();

        }

        private void City_Id_Click(object sender, EventArgs e)
        {

        }
        public void GetCountries()
        {
           
            Countries.DisplayMember = "Country_Name";
            Countries.ValueMember = "ID";
            Countries.DataSource = CitySl.GetAllBind();


          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.AppendText("\r\n" );
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int Id= Int32.Parse(CityId.Text);
            //var x = UserBLL.GetById(1);

            User user = UserSL.GetUser(UserSL.GetById(Regestration.CurrentUser.Id)); 
            SL.Role User_Role = (SL.Role)Regestration.CurrentUser.Role_Id;
            City city =CitySL.GetById(Id, User_Role);
            if(city==null)
            {
                richTextBox1.Text = string.Format("Its Not Allowed for You to get any city ");
            }
            else
            {
                richTextBox1.Text = string.Format("City Id : {0} \nCity Name : {1}", city.ID, city.City_Name);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            StartForm start = new StartForm();
            this.Hide();
            start.Show();
        }
    }
}
