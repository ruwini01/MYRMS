using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYRMS.View
{
    public partial class fCategoryView : SampleView
    {
        public fCategoryView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string query = "Select * from category where catName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        public  void btnAdd_Click_1(object sender, EventArgs e)
        {
            
        }

        private void fCategoryView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
         //   fCategoryAdd f = new fCategoryAdd();
          //  f.ShowDialog();

             MainClass.BlurBackground(new fCategoryAdd());
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fCategoryAdd f = new fCategoryAdd();
            f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            f.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
            MainClass.BlurBackground(f);
            GetData();
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if (guna2MessageDialog1.Show("Are You want to Delete?") == DialogResult.Yes)
            {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string query = "Delete from category where catID = '" + id + "'";
                Hashtable ht = new Hashtable();
                MainClass.SQL(query, ht);

                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Delete SuccessFully");
                GetData();
            }
        }
    }
}
