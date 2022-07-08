using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_4_GUI.Model
{
    internal class Item
    {

        public string Number { get; set; }
        public string Date { get; set; }
        public string Inventory_Num { get; set; }
        public string ObjectName { get; set; }
        public string price{ get; set; }
        public string Count { get; set; }

        public void save()
        {
            MessageBox.Show($"{ObjectName} added successfully");    
        }
    }
}
