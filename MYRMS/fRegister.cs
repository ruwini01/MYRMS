using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
//using System.Text.RegularExpressions;


namespace MYRMS
{
    public partial class fRegister : Form
    {
        private int id = 0;
        string query = "";
        public fRegister()
        {
            InitializeComponent();
            error_msg.Clear();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_name.Text))
            {
                error_msg.Text = "Name cannot be blank";
                txt_name.Focus();
            }
            else if (txt_name.Text.Any(char.IsDigit))
            {
                error_msg.Text = "Name cannot have numbers";
                txt_name.Focus();
            }
            
            
            
            else if (txt_email.Text.Length == 0)
            {
                error_msg.Text = "Please Enter Email Address";
                txt_email.Focus();
            }
            else if (!Regex.IsMatch(txt_email.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                error_msg.Text = "Enter a valid email. Ex:name@gmail.com";
                txt_email.Focus();
            }
            else if (txt_pwd.Text.Length == 0)
            {
                error_msg.Text = "Please Enter your Password";
                txt_pwd.Focus();
            }
            else if (txt_confirm.Text.Length == 0)
            {
                error_msg.Text = "Please Enter your Confirm Password";
                txt_confirm.Focus();
            }
            else if (txt_pwd.Text != txt_confirm.Text)
            {
                error_msg.Text = "Confirm Password must same as the Password";
                txt_confirm.Focus();
            }
            
            else if (string.IsNullOrEmpty(txt_address.Text))
            {
                error_msg.Text = "Address cannot be blank";
                txt_address.Focus();
            }
            else if (!Regex.IsMatch(txt_tp.Text, @"^(?:7|0|(?:\+94))[0-9]{8,9}$"))
            {
                error_msg.Text = "TP must have 10 numbers";
                txt_tp.Focus();
            }
            else
            {   
                error_msg.Text = "";
               // guna2MessageDialog1.Show("Saved Succeessfully");

                

                
                if (id == 0) // Insert
                {
                    query = "Insert into users Values(@Name, @email, @address, @tp,@pass,@cpass)";
                }
                else
                {
                    query = "Update users Set username = @Name, email =@email,address =  @address, tp = @tp,pass = @pass,cpass = @cpass where userID = @id";

                }

                // images
                

                Hashtable ht = new Hashtable();
                ht.Add("@id", id);
                ht.Add("@Name", txt_name.Text);
                ht.Add("@email", txt_email.Text);
                ht.Add("@address", txt_address.Text);
                ht.Add("@tp", txt_tp.Text);
                ht.Add("@pass", txt_pwd.Text);
                ht.Add("@cpass", txt_confirm.Text);

                if (MainClass.SQL(query, ht) > 0)
                {
                    guna2MessageDialog1.Show("Saved Succeessfully");
                    id = 0;
                    txt_name.Text = "";
                    txt_email.Text = "";
                    txt_address.Text = "";
                    txt_tp.Text =  "";
                    txt_pwd.Text = "";
                    txt_confirm.Text = "";


                    txt_name.Focus();
                }


                this.Hide();
                Login frm = new Login();
                frm.Show();
            }

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txt_name.Clear();
            txt_email.Clear();
            txt_pwd.Clear();
            txt_confirm.Clear();
            txt_address.Clear();
            txt_tp.Clear();
            error_msg.Clear();

        }
    }
}
