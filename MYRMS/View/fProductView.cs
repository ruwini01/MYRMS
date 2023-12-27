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
    public partial class fProductView : SampleView
    {
        public fProductView()
        {
            InitializeComponent();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fProductView_Load(object sender, EventArgs e)
        {
            GetData();
        }

        public void GetData()
        {
            string query = "select pID, pName, pPrice, CategoryID, c.catName from products p inner join category c on c.catID = p.CategoryID where pName like '%" + txtSearch.Text + "%'";
            ListBox lb = new ListBox();
            lb.Items.Add(dgvid);
            lb.Items.Add(dgvName);
            lb.Items.Add(dgvPrice);
            lb.Items.Add(dgvCatID);
            lb.Items.Add(dgvcat);


            MainClass.LoadData(query, guna2DataGridView1, lb);
        }

        public override void btnAdd_Click(object sender, EventArgs e)
        {
            //fCategoryAdd f = new fCategoryAdd();
            //f.ShowDialog();

            MainClass.BlurBackground(new fProductAdd());
            GetData();
        }

        public override void txtSearch_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fProductAdd f = new fProductAdd();
            f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
            f.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvCatID"].Value);

            MainClass.BlurBackground(f);
            GetData();
            /*
            // Edit 
             if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvedit")
             {

            fProductAdd f = new fProductAdd();
                f.id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                f.cID = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvCatID"].Value);

                MainClass.BlurBackground(f);
                GetData();

            }
        
            // Delete
            guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            if (guna2DataGridView1.CurrentCell.OwningColumn.Name == "dgvdel")
            {
                
                if (guna2MessageDialog1.Show("Are you sure you want to delete?") == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                    string query = "Delete from products where pID = '" + id + "'";
                    Hashtable ht = new Hashtable();
                    MainClass.SQL(query, ht);

                    guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                    guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                    guna2MessageDialog1.Show("Xóa thành công");
                    GetData();
                }

        
            }
            */
        }

        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                int id = Convert.ToInt32(guna2DataGridView1.CurrentRow.Cells["dgvid"].Value);
                string query = "Delete from products where pID = '" + id + "'";
                Hashtable ht = new Hashtable();
                MainClass.SQL(query, ht);

                guna2MessageDialog1.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
                guna2MessageDialog1.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
                guna2MessageDialog1.Show("Deleted Successfully");
                GetData();
        }
    }
}
