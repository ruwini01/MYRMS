using MYRMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYRMS
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        static fMain _obj;
        public static fMain Instance
        {
            get { if (_obj == null) { _obj = new fMain(); } return _obj; }

        }
        public void AddControls(Form f)
        {
            ControlsPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            ControlsPanel.Controls.Add(f);
            f.Show();

        }

        private void fMain_Load(object sender, EventArgs e)
        {
            lblUser.Text = MainClass.USER;
            _obj = this;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new fHomeView());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            AddControls(new fCategoryView());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            AddControls(new fProductView());
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            AddControls(new fTableView());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            AddControls(new fStaffView());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
