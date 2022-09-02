using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;


namespace Assignment_4_GUI.Model
{
    public class Item
    {

        private static List<Item> Items = new List<Item>();
        public string Number { get; set; }
        public string Date { get; set; }
        public string Inventory_Num { get; set; }
        public string ObjectName { get; set; }
        public string price { get; set; }
        public string Count { get; set; }

        public bool isAvailable { get; set; }
        public string Payment { get; set; }
        public bool FreeDelivery { get; set; }

        public void save()
        {
            try
            {

                SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=projectdb;Integrated Security=True;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"insert into item values({this.Number},'{this.Date}',{this.Inventory_Num},'{this.ObjectName}',{this.price},{this.Count},{this.isAvailable})", con);
                // SqlDataAdabter da = cmd.
                cmd.ExecuteReader();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static List<Item> GetAllItems()
        {
            List<Item> Items = new List<Item>();
            try
            {

                SqlConnection con = new SqlConnection("Data Source =.;Initial Catalog=projectdb;Integrated Security=True;");
                con.Open();
                SqlCommand cmd = new SqlCommand($"select * from Item", con);
                // SqlDataAdabter da = cmd.
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Items.Add(new Item()
                    {
                        Number = dr["number"].ToString(),
                        Date = dr["date"].ToString(),
                        Inventory_Num = dr["Invnum"].ToString(),
                        ObjectName = dr["name"].ToString(),
                        price = dr["price"].ToString(),
                        Count = dr["count"].ToString(),
                        isAvailable = (bool)dr["isavail"]
                    }
                    );
                }
            

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
