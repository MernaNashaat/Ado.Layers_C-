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
using User_RoleProject.DAL;
using User_RoleProject.Entities;
using User_RoleProject.SL;

namespace User_RoleProject
{
    public partial class Regestration : Form
    {
        private List<User> users;
        public static User CurrentUser ;


        public Regestration()
        {
            InitializeComponent();
            users = UserBLL.GetAllBind();
            CurrentUser = new User();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRole role = new AddRole();

            //this.Hide();
            //role.Show();
            Countries_Cities c = new Countries_Cities();
            string email = SplitSpaces(emailSignIn.Text);
            string password =SplitSpaces(passSignIn.Text);
         
            foreach (var user in users)
            {
                user.Email = SplitSpaces(user.Email);
                user.Password = SplitSpaces(user.Password);
                if(user.Email==email)
                {
                    if(user.Password==password)
                    {
                        CurrentUser.Name = SplitSpaces(user.Name);
                        CurrentUser.Email = user.Email;
                        CurrentUser.Password = user.Password;
                        CurrentUser = user;
                        this.Hide();
                    c.Show();
                    return;


                    }
                   
                }
                
            }
            MessageBox.Show("Enter Valid Mail or Password");

        }
        public static String SplitSpaces(string str)
        {
            char[] whitespace = new char[] { ' ' };
            string[] NewStr = str.Split(whitespace);
            return NewStr[0];
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            Countries_Cities c = new Countries_Cities();
            string UserEmail = SplitSpaces( EmailSignUp.Text);
            string UserName = SplitSpaces( NameSignUp.Text);
            string UserPassword =  SplitSpaces( PasswordSignUp.Text);
            int role = Int32.Parse(comboBox1.SelectedValue.ToString());

            if (UserName.Length!=0)
            {
                if(UserEmail.Length!=0)
                {
                    if(UserPassword.Length!=0)
                    {
                        UserSL.Add(UserName, UserEmail, UserPassword,role);
                        CurrentUser.Name = UserName;
                        CurrentUser.Email = UserEmail;
                        CurrentUser.Password = UserPassword;
                        CurrentUser.Id = users.Count + 1;
                        CurrentUser.Role_Id = role;
                        MessageBox.Show("Account Created Successfully");

                        this.Hide();
                        c.Show();
                        return;

                    }
                    else
                    {
                        MessageBox.Show("password is required");

                    }

                }
                else
                {
                    MessageBox.Show("Email is required");


                }


            }
            else
            {
                MessageBox.Show("UserName Is Required");


            }



        }

        private void UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Regestration_Load(object sender, EventArgs e)
        {
            GetRoles();
        }
        public void GetRoles()
        {

            comboBox1.DisplayMember = "Role_Name";
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = RoleSL.GetAllBind();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StartForm start = new StartForm();
            this.Hide();
            start.Show();
        }
    }
}
