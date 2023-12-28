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
    public partial class formMenu : Form
    {
        private frmMain main = null;
        private formMenu menu = null;
        private formCart cart = null;
        private formHistory history = null;
#pragma warning disable CS0414 // The field 'formMenu.settings' is assigned but its value is never used
        private formSettings settings = null;
#pragma warning restore CS0414 // The field 'formMenu.settings' is assigned but its value is never used

        private formPizza pizza = null;

        public formMenu()
        {
            InitializeComponent();
        }

        public formMenu(frmMain m)
        {
            main = m;
            InitializeComponent();
        }

        

        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            if (main == null || main.IsDisposed)
            {
                main = new frmMain();
            }
            main.Show();
            this.Hide();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if (menu == null || menu.IsDisposed)
            {
                menu = new formMenu();
            }

            menu.Show();
            this.Hide();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (cart == null || cart.IsDisposed)
            {
                cart = new formCart(this);
            }
            cart.Show();
            this.Hide();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (history == null || history.IsDisposed)
            {
                history = new formHistory(this);
            }
            history.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (pizza == null || pizza.IsDisposed)
            {
                pizza = new formPizza(this);
            }
            pizza.Show();
            this.Hide();
        }
    }
}
