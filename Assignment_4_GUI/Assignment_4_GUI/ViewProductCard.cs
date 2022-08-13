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
    public partial class ViewProductCard : Form
    {
        public ViewProductCard()
        {
            InitializeComponent();
        }

        private void lbl_red_Click(object sender, EventArgs e)
        {
            pnl_rightMenu.BackColor = Color.Red;
            pnl_highlight.Location =new Point( 0,lbl_red.Location.Y);
        }

        private void lbl_blue_Click(object sender, EventArgs e)
        {
            pnl_rightMenu.BackColor= Color.Blue;
            pnl_highlight.Location = new Point( 0,lbl_blue.Location.Y);
        }

        private void lbl_green_Click(object sender, EventArgs e)
        {
            pnl_rightMenu.BackColor=Color.Green;
            pnl_highlight.Location = new Point(0,lbl_green.Location.Y);
        }

        private void lbl_white_Click(object sender, EventArgs e)
        {
            pnl_rightMenu.BackColor=(Color)Color.White;
            pnl_highlight.Location = new Point(0,lbl_white.Location.Y);
        }

        private void lbl_black_Click(object sender, EventArgs e)
        {
            pnl_rightMenu.BackColor = Color.Black;
            pnl_highlight.Location = new Point(lbl_black.Location.Y);
        }

        private void productCard1_Load(object sender, EventArgs e)
        {/*
            pnl_rightMenu.Controls.Clear();
            foreach (var Item in Model.Item.GetAllItems())
            {
                ProductCard pc = new ProductCard(Item.ObjectName,(float )Double.Parse( Item.price), Item.Number, Item.isAvailable);
                pnl_rightMenu.Controls.Add(pc);
            }*/

        }

        private void ViewProductCard_Load(object sender, EventArgs e)
        {
            pnl_rightMenu.Controls.Clear();
            foreach (var Item in Model.Item.GetAllItems())
            {
                ProductCard pc = new ProductCard(Item.ObjectName, (float)Double.Parse(Item.price), Item.Number, Item.isAvailable);
                pnl_rightMenu.Controls.Add(pc);
            }


        }
    }
}
