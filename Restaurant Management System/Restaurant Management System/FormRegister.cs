using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Restaurant_Management_System
{
    public partial class FormRegister : Form
    {
        private FormLogin login = null;

        
        SqlConnection con;
        

        public FormRegister()
        {
            InitializeComponent();
        }

        public FormRegister(FormLogin l)
        {
            login = l;
            InitializeComponent();
        }


        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (login == null || login.IsDisposed)
            {

                login = new FormLogin(this);

            }
            login.Show();
            this.Hide();
        }

       

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (login == null || login.IsDisposed)
            {

                login = new FormLogin(this);

            }
            login.Show();
            this.Hide();
        }

        private void buttonRegister_Click_1(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=RUWINI-THARANGA\SQLEXPRESS;Initial Catalog=Restaurant_Management_System;Integrated Security=True");
            con.Open();

            

            SqlCommand cnn = new SqlCommand("Insert into people values(@username, @password, @confirmpassword)", con);

           

            if (textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
               
                cnn.Parameters.AddWithValue("@username", textBoxUsername.Text);
                cnn.Parameters.AddWithValue("@password", textBoxPassword.Text);
                cnn.Parameters.AddWithValue("@confirmpassword", textBoxConfirmPassword.Text);
                

                

                cnn.ExecuteNonQuery();
                con.Close();




                MessageBox.Show("Registration Sucessfull");

                textBoxUsername.Clear();
                textBoxPassword.Clear();
                textBoxConfirmPassword.Clear();



            }

            else {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      
                textBoxPassword.Clear();
                textBoxConfirmPassword.Clear();
            }

        





        }

        private void gradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
