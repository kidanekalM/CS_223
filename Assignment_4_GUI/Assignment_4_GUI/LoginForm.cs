using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_GUI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text == "Abebe" && txt_Password.Text == "0")
            {
            Hide();
            Form1 f = new Form1(this);
                f.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            txt_Username.Text = "";
            txt_Password.Text = "";
        }
    }
}