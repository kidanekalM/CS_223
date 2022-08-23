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
    public partial class DetailPage : Form
    {
        public DetailPage(Model.Item item)
        {
            InitializeComponent();
            lbl_count.Text = item.Count.ToString();
            lbl_date.Text = item.Date.ToString();
            lbl_InventoryNumber.Text = item.Inventory_Num.ToString();
            lbl_number.Text = item.Number.ToString();
            lbl_objectname.Text = item.ObjectName;
            lbl_price.Text = item.price.ToString();
            Show();
        }
    }
}
