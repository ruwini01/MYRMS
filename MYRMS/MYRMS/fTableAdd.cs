﻿using System;
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
    public partial class fTableAdd : SampleAdd
    {
        public fTableAdd()
        {
            InitializeComponent();
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
                    query = "Insert into tables Values(@Name)";
                }
                else
                {
                    query = "Update tables Set tName = @Name where tID = @id";

                }
            }

            Hashtable ht = new Hashtable();
            ht.Add("@id", id);
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
