namespace WindowsFormsApplication1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBy5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.listProduct = new System.Windows.Forms.ListView();
            this.listSource = new System.Windows.Forms.ListView();
            this.listSearch2 = new System.Windows.Forms.ListView();
            this.cbProduct = new System.Windows.Forms.CheckBox();
            this.cbSource = new System.Windows.Forms.CheckBox();
            this.cbRear = new System.Windows.Forms.CheckBox();
            this.cbFront = new System.Windows.Forms.CheckBox();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1119, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBy5ToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // addBy5ToolStripMenuItem
            // 
            this.addBy5ToolStripMenuItem.Name = "addBy5ToolStripMenuItem";
            this.addBy5ToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.addBy5ToolStripMenuItem.Text = "Add by 5";
            this.addBy5ToolStripMenuItem.Click += new System.EventHandler(this.addBy5ToolStripMenuItem_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(115, 32);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(121, 21);
            this.cbSearch.TabIndex = 9;
            this.cbSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(247, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 34);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Find";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // listProduct
            // 
            this.listProduct.HideSelection = false;
            this.listProduct.Location = new System.Drawing.Point(115, 121);
            this.listProduct.Name = "listProduct";
            this.listProduct.Size = new System.Drawing.Size(100, 349);
            this.listProduct.TabIndex = 15;
            this.listProduct.UseCompatibleStateImageBehavior = false;
            this.listProduct.View = System.Windows.Forms.View.Details;
            this.listProduct.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listProduct_ItemSelectionChanged);
            this.listProduct.SelectedIndexChanged += new System.EventHandler(this.listProduct_SelectedIndexChanged_1);
            // 
            // listSource
            // 
            this.listSource.Location = new System.Drawing.Point(234, 121);
            this.listSource.Name = "listSource";
            this.listSource.Size = new System.Drawing.Size(105, 349);
            this.listSource.TabIndex = 17;
            this.listSource.UseCompatibleStateImageBehavior = false;
            this.listSource.View = System.Windows.Forms.View.Details;
            this.listSource.SelectedIndexChanged += new System.EventHandler(this.listSource_SelectedIndexChanged);
            // 
            // listSearch2
            // 
            this.listSearch2.Location = new System.Drawing.Point(370, 121);
            this.listSearch2.Name = "listSearch2";
            this.listSearch2.Size = new System.Drawing.Size(605, 349);
            this.listSearch2.TabIndex = 14;
            this.listSearch2.UseCompatibleStateImageBehavior = false;
            // 
            // cbProduct
            // 
            this.cbProduct.AutoSize = true;
            this.cbProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProduct.Location = new System.Drawing.Point(115, 98);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(45, 17);
            this.cbProduct.TabIndex = 18;
            this.cbProduct.Text = "Use";
            this.cbProduct.UseVisualStyleBackColor = true;
            this.cbProduct.CheckedChanged += new System.EventHandler(this.cbProduct_CheckedChanged);
            // 
            // cbSource
            // 
            this.cbSource.AutoSize = true;
            this.cbSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbSource.Location = new System.Drawing.Point(234, 98);
            this.cbSource.Name = "cbSource";
            this.cbSource.Size = new System.Drawing.Size(45, 17);
            this.cbSource.TabIndex = 19;
            this.cbSource.Text = "Use";
            this.cbSource.UseVisualStyleBackColor = true;
            this.cbSource.CheckedChanged += new System.EventHandler(this.cbSource_CheckedChanged);
            // 
            // cbRear
            // 
            this.cbRear.AutoSize = true;
            this.cbRear.Checked = true;
            this.cbRear.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbRear.Location = new System.Drawing.Point(449, 98);
            this.cbRear.Name = "cbRear";
            this.cbRear.Size = new System.Drawing.Size(73, 17);
            this.cbRear.TabIndex = 20;
            this.cbRear.Text = "Wild Rear";
            this.cbRear.UseVisualStyleBackColor = true;
            this.cbRear.CheckedChanged += new System.EventHandler(this.cbRear_CheckedChanged);
            // 
            // cbFront
            // 
            this.cbFront.AutoSize = true;
            this.cbFront.Checked = true;
            this.cbFront.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbFront.Location = new System.Drawing.Point(370, 98);
            this.cbFront.Name = "cbFront";
            this.cbFront.Size = new System.Drawing.Size(74, 17);
            this.cbFront.TabIndex = 21;
            this.cbFront.Text = "Wild Front";
            this.cbFront.UseVisualStyleBackColor = true;
            this.cbFront.CheckedChanged += new System.EventHandler(this.cbFront_CheckedChanged);
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClearSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClearSearch.Location = new System.Drawing.Point(317, 32);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(64, 34);
            this.btnClearSearch.TabIndex = 22;
            this.btnClearSearch.Text = "Clear";
            this.btnClearSearch.UseVisualStyleBackColor = false;
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1119, 510);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.cbFront);
            this.Controls.Add(this.cbRear);
            this.Controls.Add(this.cbSource);
            this.Controls.Add(this.cbProduct);
            this.Controls.Add(this.listSearch2);
            this.Controls.Add(this.listSource);
            this.Controls.Add(this.listProduct);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBy5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListView listProduct;
        private System.Windows.Forms.ListView listSource;
        private System.Windows.Forms.ListView listSearch2;
        private System.Windows.Forms.CheckBox cbProduct;
        private System.Windows.Forms.CheckBox cbSource;
        private System.Windows.Forms.CheckBox cbRear;
        private System.Windows.Forms.CheckBox cbFront;
        private System.Windows.Forms.Button btnClearSearch;
    }
}

