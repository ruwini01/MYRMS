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

namespace MYRMS
{
    public partial class fStaffAdd : SampleAdd
    {
        public fStaffAdd()
        {
            InitializeComponent();
        }

        public int id = 0;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public override void btnSave_Click(object sender, EventArgs e)
        {
            string query = "";


            if (txtName.Text.Equals(""))
            {
                guna2MessageDialog1.Show("Plase Enter Name");
                return;
            }
            else
            {
                if (id == 0) // Insert
                {
                    query = "Insert into staff Values(@Name,@phone,@role)";
                }
                else
                {
                    query = "Update staff Set sName = @Name,sPhone = @Phone,sRole = @Role where staffID = @id";

                }
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
            ht.Add("@Name", txtName.Text);
            ht.Add("@phone", txtPhone.Text);
            ht.Add("@role", cbRole.Text);

            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Succeessfully");
                id = 0;
                txtName.Text = "";
                txtPhone.Text = "";
                cbRole.SelectedIndex = -1;
                txtName.Focus();
            }
        }
    }
}
