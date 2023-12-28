using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Management_System
{
    public partial class frmMain : Form
    {
        private frmMain main = null;
        private formMenu menu = null;
        private formCart cart = null;
        private formHistory history = null;
        private formSettings settings = null;   

        FormLogin login = new FormLogin();
        public frmMain()
        {
            InitializeComponent();
        }

        public frmMain(FormLogin l)
        {
            login = l;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            label3.Text = "Welcome "+FormLogin.uname;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
        private void buttonClose_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e, FormLogin formLogin)
        {
            string USER = formLogin.textBoxUsername.Text;
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (menu == null || menu.IsDisposed) {
                menu = new formMenu(this);
            }

            menu.Show();
            this.Hide();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            if (cart == null || cart.IsDisposed) {
                cart = new formCart(this);
            }
            cart.Show();
            this.Hide();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            if(main == null || main.IsDisposed)
            {
                main = new frmMain();
            }
            main.Show();
            this.Hide();

        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (history == null || history.IsDisposed)
            {
                history = new formHistory(this);
            }
            history.Show();
            this.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new formSettings(this);
            }
            settings.Show();
            this.Hide();
        }
    }
}
