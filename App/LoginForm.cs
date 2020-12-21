using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Repositories;

namespace App
{
    public partial class LoginForm : Form
    {

        internal LoginRepo lr;
        public LoginForm()
        {
            InitializeComponent();
            lr = new LoginRepo();
        }

        
        private void OnFormClose(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Loginbtnclick(object sender, EventArgs e)
        {
            string username = UNameTB.Text;
            string password = PassTB.Text;
            Login l = lr.GetUser(username, password);
                if(l!=null)
                {
                ManagementForm mf = new ManagementForm(l);
                this.Visible = false;
                mf.Visible = true;
                
                }
                else
                {
                    MessageBox.Show("Please Enter Valid User Name and Password");
                }
                    



           
                
        }

    }
}

           
            

           


        
        