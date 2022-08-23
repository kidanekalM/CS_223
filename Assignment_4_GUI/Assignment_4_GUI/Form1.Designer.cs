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
            this.components = new System.ComponentModel.Container();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.chk_options = new System.Windows.Forms.CheckedListBox();
            this.gboxPayment = new System.Windows.Forms.GroupBox();
            this.rbGpay = new System.Windows.Forms.RadioButton();
            this.rbTeleBirr = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.btn_searchByName = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.txt_INsearch = new System.Windows.Forms.TextBox();
            this.btn_searchByIN = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.gboxPayment.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Number
            // 
            this.lbl_Number.AutoSize = true;
            this.lbl_Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Number.Location = new System.Drawing.Point(3, 0);
            this.lbl_Number.Name = "lbl_Number";
            this.lbl_Number.Size = new System.Drawing.Size(93, 25);
            this.lbl_Number.TabIndex = 0;
            this.lbl_Number.Text = "Number";
            // 
            // lbl_InventoryNumber
            // 
            this.lbl_InventoryNumber.AutoSize = true;
            this.lbl_InventoryNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InventoryNumber.Location = new System.Drawing.Point(3, 135);
            this.lbl_InventoryNumber.Name = "lbl_InventoryNumber";
            this.lbl_InventoryNumber.Size = new System.Drawing.Size(197, 25);
            this.lbl_InventoryNumber.TabIndex = 1;
            this.lbl_InventoryNumber.Text = "Inventory Number";
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(3, 90);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(61, 25);
            this.lbl_Date.TabIndex = 2;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_ObjectName
            // 
            this.lbl_ObjectName.AutoSize = true;
            this.lbl_ObjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ObjectName.Location = new System.Drawing.Point(3, 45);
            this.lbl_ObjectName.Name = "lbl_ObjectName";
            this.lbl_ObjectName.Size = new System.Drawing.Size(147, 25);
            this.lbl_ObjectName.TabIndex = 3;
            this.lbl_ObjectName.Text = "Object Name";
            // 
            // lbl_Count
            // 
            this.lbl_Count.AutoSize = true;
            this.lbl_Count.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Count.Location = new System.Drawing.Point(3, 180);
            this.lbl_Count.Name = "lbl_Count";
            this.lbl_Count.Size = new System.Drawing.Size(74, 25);
            this.lbl_Count.TabIndex = 4;
            this.lbl_Count.Text = "Count";
            // 
            // lbl_Price
            // 
            this.lbl_Price.AutoSize = true;
            this.lbl_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Price.Location = new System.Drawing.Point(3, 225);
            this.lbl_Price.Name = "lbl_Price";
            this.lbl_Price.Size = new System.Drawing.Size(66, 25);
            this.lbl_Price.TabIndex = 5;
            this.lbl_Price.Text = "Price";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(125, 332);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(142, 29);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(481, 332);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(142, 29);
            this.btn_Cancel.TabIndex = 7;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // txt_Number
            // 
            this.txt_Number.Location = new System.Drawing.Point(209, 3);
            this.txt_Number.Name = "txt_Number";
            this.txt_Number.Size = new System.Drawing.Size(180, 20);
            this.txt_Number.TabIndex = 8;
            // 
            // txt_InventoryNumber
            // 
            this.txt_InventoryNumber.Location = new System.Drawing.Point(209, 138);
            this.txt_InventoryNumber.Name = "txt_InventoryNumber";
            this.txt_InventoryNumber.Size = new System.Drawing.Size(180, 20);
            this.txt_InventoryNumber.TabIndex = 9;
            // 
            // txt_ObjectName
            // 
            this.txt_ObjectName.Location = new System.Drawing.Point(209, 48);
            this.txt_ObjectName.Name = "txt_ObjectName";
            this.txt_ObjectName.Size = new System.Drawing.Size(180, 20);
            this.txt_ObjectName.TabIndex = 10;
            // 
            // txt_Count
            // 
            this.txt_Count.Location = new System.Drawing.Point(209, 183);
            this.txt_Count.Name = "txt_Count";
            this.txt_Count.Size = new System.Drawing.Size(180, 20);
            this.txt_Count.TabIndex = 11;
            // 
            // txt_Price
            // 
            this.txt_Price.Location = new System.Drawing.Point(209, 228);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(180, 20);
            this.txt_Price.TabIndex = 12;
            // 
            // dt_dateTimePicker
            // 
            this.dt_dateTimePicker.Location = new System.Drawing.Point(209, 93);
            this.dt_dateTimePicker.Name = "dt_dateTimePicker";
            this.dt_dateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.dt_dateTimePicker.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 367);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(736, 76);
            this.dataGridView1.TabIndex = 14;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chk_options
            // 
            this.chk_options.BackColor = System.Drawing.SystemColors.Control;
            this.chk_options.FormattingEnabled = true;
            this.chk_options.Items.AddRange(new object[] {
            "Availabliliy",
            "Free Delivery "});
            this.chk_options.Location = new System.Drawing.Point(691, 77);
            this.chk_options.Name = "chk_options";
            this.chk_options.Size = new System.Drawing.Size(97, 34);
            this.chk_options.TabIndex = 16;
            // 
            // gboxPayment
            // 
            this.gboxPayment.Controls.Add(this.rbGpay);
            this.gboxPayment.Controls.Add(this.rbTeleBirr);
            this.gboxPayment.Location = new System.Drawing.Point(690, 134);
            this.gboxPayment.Name = "gboxPayment";
            this.gboxPayment.Size = new System.Drawing.Size(98, 70);
            this.gboxPayment.TabIndex = 18;
            this.gboxPayment.TabStop = false;
            this.gboxPayment.Text = "Payment";
            // 
            // rbGpay
            // 
            this.rbGpay.AutoSize = true;
            this.rbGpay.Location = new System.Drawing.Point(6, 42);
            this.rbGpay.Name = "rbGpay";
            this.rbGpay.Size = new System.Drawing.Size(48, 17);
            this.rbGpay.TabIndex = 2;
            this.rbGpay.TabStop = true;
            this.rbGpay.Text = "gpay";
            this.rbGpay.UseVisualStyleBackColor = true;
            // 
            // rbTeleBirr
            // 
            this.rbTeleBirr.AutoSize = true;
            this.rbTeleBirr.Location = new System.Drawing.Point(6, 19);
            this.rbTeleBirr.Name = "rbTeleBirr";
            this.rbTeleBirr.Size = new System.Drawing.Size(60, 17);
            this.rbTeleBirr.TabIndex = 1;
            this.rbTeleBirr.TabStop = true;
            this.rbTeleBirr.Text = "Telebirr\r\n";
            this.rbTeleBirr.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(743, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(48, 25);
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(16, 18);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 24);
            this.lbl_username.TabIndex = 20;
            // 
            // btn_searchByName
            // 
            this.btn_searchByName.Location = new System.Drawing.Point(44, 63);
            this.btn_searchByName.Name = "btn_searchByName";
            this.btn_searchByName.Size = new System.Drawing.Size(93, 23);
            this.btn_searchByName.TabIndex = 21;
            this.btn_searchByName.Text = "Name Search ";
            this.btn_searchByName.UseVisualStyleBackColor = true;
            this.btn_searchByName.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(44, 92);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(122, 20);
            this.txt_search.TabIndex = 22;
            // 
            // txt_INsearch
            // 
            this.txt_INsearch.Location = new System.Drawing.Point(44, 161);
            this.txt_INsearch.Name = "txt_INsearch";
            this.txt_INsearch.Size = new System.Drawing.Size(122, 20);
            this.txt_INsearch.TabIndex = 24;
            // 
            // btn_searchByIN
            // 
            this.btn_searchByIN.Location = new System.Drawing.Point(44, 132);
            this.btn_searchByIN.Name = "btn_searchByIN";
            this.btn_searchByIN.Size = new System.Drawing.Size(93, 23);
            this.btn_searchByIN.TabIndex = 23;
            this.btn_searchByIN.Text = "IN Search";
            this.btn_searchByIN.UseVisualStyleBackColor = true;
            this.btn_searchByIN.Click += new System.EventHandler(this.btn_searchByIN_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Number, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_Number, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_ObjectName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_ObjectName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Date, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dt_dateTimePicker, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_InventoryNumber, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txt_InventoryNumber, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Count, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Count, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_Price, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Price, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(210, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 271);
            this.tableLayoutPanel1.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.txt_INsearch);
            this.Controls.Add(this.btn_searchByIN);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_searchByName);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gboxPayment);
            this.Controls.Add(this.chk_options);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.gboxPayment.ResumeLayout(false);
            this.gboxPayment.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.CheckedListBox chk_options;
        private System.Windows.Forms.GroupBox gboxPayment;
        private System.Windows.Forms.RadioButton rbGpay;
        private System.Windows.Forms.RadioButton rbTeleBirr;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_searchByName;
        private System.Windows.Forms.TextBox txt_INsearch;
        private System.Windows.Forms.Button btn_searchByIN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

