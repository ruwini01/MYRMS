using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Restaurant_Management_System
{
    public partial class formPizza : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=RUWINI-THARANGA\SQLEXPRESS;Initial Catalog=Restaurant_Management_System;Integrated Security=True");

        FormLogin login = new FormLogin();
        private formMenu menu = null;

        List<(string FoodName, decimal FoodPrice, int quantity)> selectedFoods = new List<(string, decimal, int)>();
        // ... (Populate the list with selected foods and prices)

        

        public formPizza()
        {
            InitializeComponent();
        }

        public formPizza(formMenu m)
        {
            menu = m;
            InitializeComponent();
        }

        private void formPizza_Load(object sender, EventArgs e)
        {
            
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxBBQ_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownBBQ.Visible = checkBoxBBQ.Checked;
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private int GetNewOrderId()
        {
            // No need to generate ID manually, database will handle it
            return 0; // Placeholder value, will be replaced by the database
        }


       

        private void checkBoxPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDownPepperoni.Visible = checkBoxPepperoni.Checked;
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to the cart");
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Added to the cart");
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {

        }
    }
}
