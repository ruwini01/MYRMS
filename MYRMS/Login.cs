using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MYRMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

    private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fMain frm = new fMain();
            frm.Show();
            /*
            if (txtPass.Text == "" || txtPass.Text == "")
            {
                guna2MessageDialog1.Show("Please Enter UserName or Password");
                return;
            }
            else if (MainClass.IsValidUser(txtPass.Text,txtPass.Text) == false)
            {
                guna2MessageDialog1.Show("Invalid UserName or Password");
                return;
            }
            else
            {
                this.Hide();
                fMain frm = new fMain();
                frm.Show();
            }*/
            
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            fRegister frm = new fRegister();
            frm.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
