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
using System.Xml.Linq;

namespace MYRMS
{
    public partial class fCategoryAdd : SampleAdd
    {
        public fCategoryAdd()
        {
            InitializeComponent();
        }

        private void fCategoryAdd_Load(object sender, EventArgs e)
        {

        }
        public int id = 0;
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
                    query = "Insert into category Values(@Name)";
                }
                else
                {
                    query = "Update category Set catName = @Name where catID = @id";

                }
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id",id);
            ht.Add("@Name", txtName.Text);

            if (MainClass.SQL(query, ht) > 0)
            {
                guna2MessageDialog1.Show("Saved Succeessfully");
                id = 0;
                txtName.Text = "";
                txtName.Focus();
            }
        }
    }
}
