using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment_4_GUI.Model;

namespace Assignment_4_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Item item = new Item()
            {
                Number = txt_Number.Text,
                ObjectName = txt_ObjectName.Text,
                Count = txt_Count.Text,
                price = txt_Price.Text,
                Inventory_Num = txt_InventoryNumber.Text,
                Date = dt_dateTimePicker.Text
            };
            item.save();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
