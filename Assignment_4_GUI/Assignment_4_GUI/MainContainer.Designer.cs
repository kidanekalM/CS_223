namespace Assignment_4_GUI
{
    partial class MainContainer
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catagoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsToolStripMenuItem,
            this.catagoryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductsToolStripMenuItem,
            this.updateProductsToolStripMenuItem,
            this.viewProductsToolStripMenuItem});
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.productsToolStripMenuItem.Text = "products";
            // 
            // addProductsToolStripMenuItem
            // 
            this.addProductsToolStripMenuItem.Name = "addProductsToolStripMenuItem";
            this.addProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProductsToolStripMenuItem.Text = "add products";
            this.addProductsToolStripMenuItem.Click += new System.EventHandler(this.addProductsToolStripMenuItem_Click);
            // 
            // updateProductsToolStripMenuItem
            // 
            this.updateProductsToolStripMenuItem.Name = "updateProductsToolStripMenuItem";
            this.updateProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.updateProductsToolStripMenuItem.Text = "delete products";
            // 
            // catagoryToolStripMenuItem
            // 
            this.catagoryToolStripMenuItem.Name = "catagoryToolStripMenuItem";
            this.catagoryToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.catagoryToolStripMenuItem.Text = "catagory";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // viewProductsToolStripMenuItem
            // 
            this.viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            this.viewProductsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.viewProductsToolStripMenuItem.Text = "view products";
            this.viewProductsToolStripMenuItem.Click += new System.EventHandler(this.viewProductsToolStripMenuItem_Click);
            // 
            // MainContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainContainer";
            this.Text = "MainContainer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainContainer_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catagoryToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewProductsToolStripMenuItem;
    }
}