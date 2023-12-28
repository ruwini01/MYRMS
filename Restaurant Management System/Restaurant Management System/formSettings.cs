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
    public partial class formSettings : Form
    {
        private frmMain main = null;
        private formMenu menu = null;
        private formCart cart = null;
        private formHistory history = null;
        private formSettings settings = null;
#pragma warning disable CS0169 // The field 'formSettings.formMenu' is never used
        private formMenu formMenu;
#pragma warning restore CS0169 // The field 'formSettings.formMenu' is never used
        public formSettings()
        {
            InitializeComponent();
        }

        public formSettings(frmMain m)
        { 
            main = m;
            InitializeComponent();
        }

       

        private void formSettings_Load(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            if (main == null || main.IsDisposed)
            {
                main = new frmMain();
            }
            main.Show();
            this.Hide();
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            if (menu == null || menu.IsDisposed)
            {
                menu = new formMenu();
            }

            menu.Show();
            this.Hide();
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            if (cart == null || cart.IsDisposed)
            {
                cart = new formCart();
            }
            cart.Show();
            this.Hide();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            if (history == null || history.IsDisposed)
            {
                history = new formHistory();
            }
            history.Show();
            this.Hide();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            if (settings == null || settings.IsDisposed)
            {
                settings = new formSettings();
            }
            settings.Show();
            this.Hide();
        }
    }
}
