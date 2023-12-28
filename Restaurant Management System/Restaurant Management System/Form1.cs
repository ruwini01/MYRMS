using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Restaurant_Management_System
{
    public partial class FormLogin : Form
    {
        public static string uname;
        public static string pass;

        private FormRegister register = null;

        private frmMain frmmain = null;


        public FormRegister FormRegister { get; }

        

        public FormLogin()
        {
            InitializeComponent();
        }

        public FormLogin(FormRegister formRegister)
        {
            FormRegister = formRegister;
        }

        SqlConnection conn = new SqlConnection(@"Data Source=RUWINI-THARANGA\SQLEXPRESS;Initial Catalog=Restaurant_Management_System;Integrated Security=True");

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonCreateNewAccount_Click(object sender, EventArgs e)
        {
            if (register == null || register.IsDisposed) {
                register = new FormRegister(this);
            }

            register.Show();
            this.Hide();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click_1(object sender, EventArgs e)
        {
            uname = textBoxUsername.Text;
            pass = textBoxPassword.Text;

            String username, user_password;

            username = textBoxUsername.Text;
            user_password = textBoxPassword.Text;

            try {
                String query = "Select * from people where username = '" + username + "' AND password='" + user_password + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    
                    username = textBoxUsername.Text;
                    user_password = textBoxPassword.Text;

                    //nextpage
                    if (frmmain == null || frmmain.IsDisposed)
                    {
                        frmmain = new frmMain(this);
                    }
                    frmmain.Show();
                    this.Hide();

                }

                else {
                    MessageBox.Show("invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxUsername.Clear();
                    textBoxPassword.Clear();

                    textBoxUsername.Focus();
                  
                }
            } 
            catch {
                MessageBox.Show("Error");
            } 
            finally {
                conn.Close();
            }

            
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
