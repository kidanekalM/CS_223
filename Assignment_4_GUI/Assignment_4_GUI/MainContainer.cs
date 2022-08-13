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
    public partial class MainContainer : Form
    {
        LoginForm loginForm;
        public MainContainer(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
        }

        private void addProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form = new Form1(loginForm);
            form.MdiParent = this;
            form.Show();
           
        }

        private void MainContainer_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginForm.Show();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            ViewProductCard vpd = new ViewProductCard();
            vpd.MdiParent = this;
            vpd.Show();
        }
    }
}
