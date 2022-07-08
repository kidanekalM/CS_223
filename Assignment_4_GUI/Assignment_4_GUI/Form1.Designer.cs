namespace Assignment_4_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Number = new System.Windows.Forms.Label();
            this.lbl_InventoryNumber = new System.Windows.Forms.Label();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_ObjectName = new System.Windows.Forms.Label();
            this.lbl_Count = new System.Windows.Forms.Label();
            this.lbl_Price = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.txt_Number = new System.Windows.Forms.TextBox();
            this.txt_InventoryNumber = new System.Windows.Forms.TextBox();
            this.txt_ObjectName = new System.Windows.Forms.TextBox();
            this.txt_Count = new System.Windows.Forms.TextBox();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.dt_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.Location = new System.Drawing.Point(68, 52);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(93, 25);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_InventoryNumber
            // 
            this.lbl_InventoryNumber.AutoSize = true;
            this.lbl_InventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InventoryNumber.Location = new System.Drawing.Point(453, 52);
            this.lbl_InventoryNumber.Name = "lbl_InventoryNumber";
            this.lbl_InventoryNumber.Size = new System.Drawing.Size(197, 25);
            this.lbl_InventoryNumber.TabIndex = 1;
            this.lbl_InventoryNumber.Text = "Inventory Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(234, 52);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(61, 25);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_ObjectName
            // 
            this.lbl_ObjectName.AutoSize = true;
            this.lbl_ObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ObjectName.Location = new System.Drawing.Point(68, 170);
            this.lbl_ObjectName.Name = "lbl_ObjectName";
            this.lbl_ObjectName.Size = new System.Drawing.Size(147, 25);
            this.lbl_ObjectName.TabIndex = 3;
            this.lbl_ObjectName.Text = "Object Name";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(68, 248);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(74, 25);
            this.lbl_Count.TabIndex = 4;
            this.lbl_Count.Text = "Count";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(272, 259);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(66, 25);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(73, 328);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(142, 29);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(305, 328);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 29);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(73, 113);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(142, 20);
            this.txt_Number.TabIndex = 8;
            // 
            // txt_InventoryNumber
            // 
            this.txt_InventoryNumber.Location = new System.Drawing.Point(458, 113);
            this.txt_InventoryNumber.Name = "txt_InventoryNumber";
            this.txt_InventoryNumber.Size = new System.Drawing.Size(142, 20);
            this.txt_InventoryNumber.TabIndex = 9;
            // 
            // txt_ObjectName
            // 
            this.txt_ObjectName.Location = new System.Drawing.Point(73, 215);
            this.txt_ObjectName.Name = "txt_ObjectName";
            this.txt_ObjectName.Size = new System.Drawing.Size(142, 20);
            this.txt_ObjectName.TabIndex = 10;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(73, 288);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(142, 20);
            this.txt_Count.TabIndex = 11;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(277, 288);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(142, 20);
            this.txt_Price.TabIndex = 12;
            // 
            // dt_dateTimePicker
            // 
            this.dt_dateTimePicker.Location = new System.Drawing.Point(239, 113);
            this.dt_dateTimePicker.Name = "dt_dateTimePicker";
            this.dt_dateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.dt_dateTimePicker.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dt_dateTimePicker);
            this.Controls.Add(this.txt_Price);
            this.Controls.Add(this.txt_Count);
            this.Controls.Add(this.txt_ObjectName);
            this.Controls.Add(this.txt_InventoryNumber);
            this.Controls.Add(this.txt_Number);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_Price);
            this.Controls.Add(this.lbl_Count);
            this.Controls.Add(this.lbl_ObjectName);
            this.Controls.Add(this.lbl_Date);
            this.Controls.Add(this.lbl_InventoryNumber);
            this.Controls.Add(this.lbl_Number);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Number;
        private System.Windows.Forms.Label lbl_InventoryNumber;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_ObjectName;
        private System.Windows.Forms.Label lbl_Count;
        private System.Windows.Forms.Label lbl_Price;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.TextBox txt_Number;
        private System.Windows.Forms.TextBox txt_InventoryNumber;
        private System.Windows.Forms.TextBox txt_ObjectName;
        private System.Windows.Forms.TextBox txt_Count;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.DateTimePicker dt_dateTimePicker;
    }
}

