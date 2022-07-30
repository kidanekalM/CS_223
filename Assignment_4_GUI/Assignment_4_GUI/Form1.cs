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
using System.Text.RegularExpressions;

namespace Assignment_4_GUI
{
    public partial class Form1 : Form
    {
        /***
         * 
         * checked list box to add many 
         * */
        LoginForm Log;
        public Form1(LoginForm Login)
        {
            Log = Login;
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {

            string s = "";
            /**
             * foreach loop
             * 
             * **/
            foreach (var item in chk_options.CheckedItems)
            {
                s += item.ToString();
            }
            MessageBox.Show(s);
            
            /**
             * by default they are in one geoup
             * Radio button needs a group box
             * 
             * **/
            Regex checkPrice = new Regex(@"^[0-9]+.[0-9]{2}$");
            Regex checkNumber = new Regex(@"^[0-9]+$");
            
            if ((!checkNumber.IsMatch(txt_Count.Text)) || (!checkNumber.IsMatch(txt_Count.Text)) || (!checkNumber.IsMatch(txt_InventoryNumber.Text)) || (!checkPrice.IsMatch(txt_Price.Text) || (!checkNumber.IsMatch(txt_Number.Text))) )
            {
                if (!checkPrice.IsMatch(txt_Price.Text))
                {
                    errorProvider1.SetError(txt_Price, "Price must be 4 digit postive decimal ");
                    
                }
                else
                {
                    errorProvider1.SetError(txt_Price, "");
                }
                if (!checkNumber.IsMatch(txt_Number.Text))
                {
                    errorProvider1.SetError(txt_Number, "Number must be 4 digit postive integer");
                }
                else
                {
                    errorProvider1.SetError(txt_Number, "");
                }

                if (!checkNumber.IsMatch(txt_Count.Text))
                {
                    errorProvider1.SetError(txt_Count, "Count must be a 4 digit postive integer");
                }
                else
                {
                    errorProvider1.SetError(txt_Count, "");
                }
                if (string.IsNullOrEmpty(txt_ObjectName.Text))
                {
                    errorProvider1.SetError(txt_ObjectName, "Name is required");
                }
                else
                {
                    errorProvider1.SetError(txt_ObjectName, "");
                }
                if (string.IsNullOrEmpty(txt_InventoryNumber.Text))
                {
                    errorProvider1.SetError(txt_InventoryNumber, "Inventory Number is required");
                }
                else
                {
                    errorProvider1.SetError(txt_InventoryNumber, "");
                }
                if (!checkNumber.IsMatch(txt_InventoryNumber.Text))
                {
                    errorProvider1.SetError(txt_InventoryNumber, "Inventory number must be 4 digit postive integer");
                }
                else
                {
                    errorProvider1.SetError(txt_InventoryNumber, "");
                }
                if (!checkNumber.IsMatch(txt_InventoryNumber.Text))
                {
                    errorProvider1.SetError(txt_InventoryNumber, "Inventory number must be 4 digit postive integer");
                }
                else
                {
                    errorProvider1.SetError(txt_InventoryNumber, "");
                }
            }
            else
            {
                errorProvider1.Clear();
                Item item = new Item()
                {
                    Number = txt_Number.Text,
                    ObjectName = txt_ObjectName.Text,
                    Count = txt_Count.Text,
                    price = txt_Price.Text,
                    Inventory_Num = txt_InventoryNumber.Text,
                    Date = dt_dateTimePicker.Text
                };
                if (rbTeleBirr.Checked)
                {
                    item.Payment = rbTeleBirr.Text;
                }
                else
                {
                    item.Payment = rbGpay.Text;
                }
                int i = 0;
                foreach(var Items in chk_options.Items)
                {
                   
                    if (i == 0)
                    {
                        if (Items.Equals(item.isAvailable)) ;
                        else item.isAvailable = true;
                             
                    }
                    else if (i == 1)
                    {
                        if (Items.Equals(item.FreeDelivery)) ;
                        else 
                        item.FreeDelivery =  false;
                    }
                    i++;
                    
                }

                item.save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Item.GetAllItems();
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Log.Show();
        }
    }
}
