using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace Assignment_4_GUI.Model
{
    internal class Item
    {
        private static List<Item> Items = new List<Item>();
        public string Number { get; set; }
        public string Date { get; set; }
        public string Inventory_Num { get; set; }
        public string ObjectName { get; set; }
        public string price{ get; set; }
        public string Count { get; set; }

        public bool isAvailable { get; set; }
        public string Payment { get; set; }
        public bool FreeDelivery { get; set; }

        public void save()
        {
            Items.Add(this);
            MessageBox.Show($"{ObjectName} added successfully");    
        }
        public static List<Item> GetAllItems()
        {
            return Items;
            
        }
        public static List<Item> SearchByName(string s)
        {
            return GetAllItems().FindAll( item => item.ObjectName  == s);
        }
        public static Item SearchByInventoryNumber (string inventoryNumber)
        {
            return GetAllItems().Find(x => x.Inventory_Num == inventoryNumber);
        }
    }
}
