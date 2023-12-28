using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Restaurant_Management_System
{
    class MainClass
    {

        public static readonly string con_string = @"Data Source=RUWINI-THARANGA\SQLEXPRESS;Initial Catalog=Restaurant_Management_System;Integrated Security=True";

        public static SqlConnection con = new SqlConnection(con_string);
        public static int SQl(string qry, Hashtable ht) {
            int res = 0;

            try {
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht) {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if(con.State == ConnectionState.Closed) { 
                    con.Open(); 
                }

                res = cmd.ExecuteNonQuery(); 
                
                if(con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }

            catch(Exception ex) {

                MessageBox.Show(ex.ToString());
                con.Close() ;   
            }

            return res;
        }


        //For loading data from database

        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            try { 
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++) {

                    string colName1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colName1].DataPropertyName = dt.Columns[i].ToString();
                }

                gv.DataSource = dt;
            }

            catch(Exception ex) {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        }
    }
}
