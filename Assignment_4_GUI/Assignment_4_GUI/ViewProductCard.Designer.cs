namespace Assignment_4_GUI
{
    partial class ViewProductCard
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
            this.pnl_Leftmenu = new System.Windows.Forms.Panel();
            this.pnl_highlight = new System.Windows.Forms.Panel();
            this.lbl_black = new System.Windows.Forms.Label();
            this.lbl_white = new System.Windows.Forms.Label();
            this.lbl_green = new System.Windows.Forms.Label();
            this.lbl_blue = new System.Windows.Forms.Label();
            this.lbl_red = new System.Windows.Forms.Label();
            this.pnl_rightMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.productCard1 = new Assignment_4_GUI.ProductCard();
            this.productCard2 = new Assignment_4_GUI.ProductCard();
            this.pnl_Leftmenu.SuspendLayout();
            this.pnl_rightMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Leftmenu
            // 
            this.pnl_Leftmenu.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnl_Leftmenu.Controls.Add(this.pnl_highlight);
            this.pnl_Leftmenu.Controls.Add(this.lbl_black);
            this.pnl_Leftmenu.Controls.Add(this.lbl_white);
            this.pnl_Leftmenu.Controls.Add(this.lbl_green);
            this.pnl_Leftmenu.Controls.Add(this.lbl_blue);
            this.pnl_Leftmenu.Controls.Add(this.lbl_red);
            this.pnl_Leftmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_Leftmenu.Location = new System.Drawing.Point(0, 0);
            this.pnl_Leftmenu.Name = "pnl_Leftmenu";
            this.pnl_Leftmenu.Size = new System.Drawing.Size(108, 450);
            this.pnl_Leftmenu.TabIndex = 0;
            // 
            // pnl_highlight
            // 
            this.pnl_highlight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.pnl_highlight.Location = new System.Drawing.Point(0, 87);
            this.pnl_highlight.Name = "pnl_highlight";
            this.pnl_highlight.Size = new System.Drawing.Size(12, 20);
            this.pnl_highlight.TabIndex = 5;
            // 
            // lbl_black
            // 
            this.lbl_black.AutoSize = true;
            this.lbl_black.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_black.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_black.Location = new System.Drawing.Point(18, 309);
            this.lbl_black.Name = "lbl_black";
            this.lbl_black.Size = new System.Drawing.Size(66, 20);
            this.lbl_black.TabIndex = 4;
            this.lbl_black.Text = "BLACK";
            this.lbl_black.Click += new System.EventHandler(this.lbl_black_Click);
            // 
            // lbl_white
            // 
            this.lbl_white.AutoSize = true;
            this.lbl_white.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_white.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_white.Location = new System.Drawing.Point(18, 268);
            this.lbl_white.Name = "lbl_white";
            this.lbl_white.Size = new System.Drawing.Size(66, 20);
            this.lbl_white.TabIndex = 3;
            this.lbl_white.Text = "WHITE";
            this.lbl_white.Click += new System.EventHandler(this.lbl_white_Click);
            // 
            // lbl_green
            // 
            this.lbl_green.AutoSize = true;
            this.lbl_green.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_green.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_green.Location = new System.Drawing.Point(18, 215);
            this.lbl_green.Name = "lbl_green";
            this.lbl_green.Size = new System.Drawing.Size(72, 20);
            this.lbl_green.TabIndex = 2;
            this.lbl_green.Text = "GREEN";
            this.lbl_green.Click += new System.EventHandler(this.lbl_green_Click);
            // 
            // lbl_blue
            // 
            this.lbl_blue.AutoSize = true;
            this.lbl_blue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_blue.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_blue.Location = new System.Drawing.Point(18, 154);
            this.lbl_blue.Name = "lbl_blue";
            this.lbl_blue.Size = new System.Drawing.Size(56, 20);
            this.lbl_blue.TabIndex = 1;
            this.lbl_blue.Text = "BLUE";
            this.lbl_blue.Click += new System.EventHandler(this.lbl_blue_Click);
            // 
            // lbl_red
            // 
            this.lbl_red.AutoSize = true;
            this.lbl_red.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_red.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_red.Location = new System.Drawing.Point(18, 87);
            this.lbl_red.Name = "lbl_red";
            this.lbl_red.Size = new System.Drawing.Size(47, 20);
            this.lbl_red.TabIndex = 0;
            this.lbl_red.Text = "RED";
            this.lbl_red.Click += new System.EventHandler(this.lbl_red_Click);
            // 
            // pnl_rightMenu
            // 
            this.pnl_rightMenu.Controls.Add(this.productCard1);
            this.pnl_rightMenu.Controls.Add(this.productCard2);
            this.pnl_rightMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_rightMenu.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnl_rightMenu.Location = new System.Drawing.Point(108, 0);
            this.pnl_rightMenu.Name = "pnl_rightMenu";
            this.pnl_rightMenu.Size = new System.Drawing.Size(692, 450);
            this.pnl_rightMenu.TabIndex = 3;
            // 
            // productCard1
            // 
            this.productCard1.BackColor = System.Drawing.SystemColors.Control;
            this.productCard1.Desc = "21";
            this.productCard1.Dock = System.Windows.Forms.DockStyle.Left;
            this.productCard1.Location = new System.Drawing.Point(12, 3);
            this.productCard1.Name = "productCard1";
            this.productCard1.Price = "21";
            this.productCard1.Size = new System.Drawing.Size(677, 0);
            this.productCard1.TabIndex = 0;
            this.productCard1.Title = "21";
            this.productCard1.Load += new System.EventHandler(this.productCard1_Load);
            // 
            // productCard2
            // 
            this.productCard2.BackColor = System.Drawing.SystemColors.Control;
            this.productCard2.Desc = null;
            this.productCard2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.productCard2.Location = new System.Drawing.Point(15, 9);
            this.productCard2.Name = "productCard2";
            this.productCard2.Price = null;
            this.productCard2.Size = new System.Drawing.Size(674, 132);
            this.productCard2.TabIndex = 1;
            this.productCard2.Title = null;
            // 
            // ViewProductCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl_rightMenu);
            this.Controls.Add(this.pnl_Leftmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewProductCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewProductCard";
            this.Load += new System.EventHandler(this.ViewProductCard_Load);
            this.pnl_Leftmenu.ResumeLayout(false);
            this.pnl_Leftmenu.PerformLayout();
            this.pnl_rightMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Leftmenu;
        private System.Windows.Forms.Label lbl_black;
        private System.Windows.Forms.Label lbl_white;
        private System.Windows.Forms.Label lbl_green;
        private System.Windows.Forms.Label lbl_blue;
        private System.Windows.Forms.Label lbl_red;
        private System.Windows.Forms.Panel pnl_highlight;
        private System.Windows.Forms.FlowLayoutPanel pnl_rightMenu;
        private ProductCard productCard1;
        private ProductCard productCard2;
    }
}