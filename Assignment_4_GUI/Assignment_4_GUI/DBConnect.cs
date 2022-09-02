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
namespace Assignment_4_GUI
{
    public partial class DBConnect : Form
    {
        public DBConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=projectdb;Integrated Security=True;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"Insert into tobedeleted values ({textBox1.Text},'{textBox2.Text}',{textBox3.Text})", con);
                MessageBox.Show(cmd.ExecuteNonQuery()+"");
                this.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                this.BackColor = Color.Red;
                MessageBox.Show(ex.Message);
                this.BackColor = Color.White;
            }
            }
    }
}
