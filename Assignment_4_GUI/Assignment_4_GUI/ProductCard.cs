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
    public partial class ProductCard : UserControl
    {
        private string _title;


        public string Title
        {
            get { return _title; }
            set { _title = value; lbl_title.Text = Title; }
        }
        private string _price;

        public string Price
        {
            get { return _price;}
            set { _price = value;  lbl_price.Text = Price; }
        }
        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; lbl_description.Text = Desc; }
        }
        public ProductCard()
        {
            InitializeComponent();
        }


        public ProductCard(string Name, float price, string description, bool availability)
        {
            InitializeComponent();
            this.Name = Name;

            this.Price = price.ToString();
            this.Desc = description;
            this.Title = Name;
            if (!availability)
            {
                this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}