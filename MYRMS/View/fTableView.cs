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
    public partial class fTableView : SampleView
    {
        public fTableView()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            string query = "Select * from tabless where tName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);

            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        private void fTableView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
          //  fTableAdd f = new fTableAdd();
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
            
            f.ShowDialog();
            GetData();
            /*
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
            {

                fCategoryAdd f = new fCategoryAdd();
                f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                f.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
                MainClass.BlurBackground(f);
                f.ShowDialog();
                GetData();

            }
            // Delete
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {


                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
                if (guna2MessageDialog1.Show("Are you sure You want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from tables where tID = '" + id + "'";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(query, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Deleted Successfully");
                    GetData();
                }

            }*/
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            fCategoryAdd f = new fCategoryAdd();
            f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            f.txtName.Text = Convert.ToString(guna2DataGridView1.CurrentRow.Cells["dgvName"].Value);
            MainClass.BlurBackground(f);
            f.ShowDialog();
            GetData();
        }
    }
}
