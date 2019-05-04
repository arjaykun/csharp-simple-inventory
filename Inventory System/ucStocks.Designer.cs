namespace Inventory_System
{
    partial class ucStocks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.lstItems = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNew = new MetroFramework.Controls.MetroTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAdd = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtStocks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 80);
            this.panel3.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 80);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(57, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "STOCKS";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Inventory_System.Properties.Resources.appbar_stock;
            this.pictureBox3.Location = new System.Drawing.Point(1, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(67, 52);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(-1, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 36);
            this.panel2.TabIndex = 1;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(294, 102);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 21;
            this.metroLabel5.Text = "Search Items:";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(386, 98);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(239, 23);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lstItems
            // 
            this.lstItems.BackColor = System.Drawing.Color.White;
            this.lstItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstItems.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstItems.FullRowSelect = true;
            this.lstItems.Location = new System.Drawing.Point(294, 127);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(539, 437);
            this.lstItems.TabIndex = 19;
            this.lstItems.UseCompatibleStateImageBehavior = false;
            this.lstItems.View = System.Windows.Forms.View.Details;
            this.lstItems.Click += new System.EventHandler(this.lstItems_Click);
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "ID";
            this.columnHeader5.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "Item Code";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "Item Name";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Price";
            this.columnHeader3.Width = 105;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Stocks";
            this.columnHeader4.Width = 105;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel6);
            this.groupBox1.Controls.Add(this.txtNew);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtStocks);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 430);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UPDATE STOCKS";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Enabled = false;
            this.metroLabel6.Location = new System.Drawing.Point(22, 259);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(79, 19);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "New Stocks ";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // txtNew
            // 
            // 
            // 
            // 
            this.txtNew.CustomButton.Image = null;
            this.txtNew.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtNew.CustomButton.Name = "";
            this.txtNew.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNew.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNew.CustomButton.TabIndex = 1;
            this.txtNew.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNew.CustomButton.UseSelectable = true;
            this.txtNew.CustomButton.Visible = false;
            this.txtNew.Enabled = false;
            this.txtNew.Lines = new string[0];
            this.txtNew.Location = new System.Drawing.Point(22, 284);
            this.txtNew.MaxLength = 32767;
            this.txtNew.Name = "txtNew";
            this.txtNew.PasswordChar = '\0';
            this.txtNew.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNew.SelectedText = "";
            this.txtNew.SelectionLength = 0;
            this.txtNew.SelectionStart = 0;
            this.txtNew.ShortcutsEnabled = true;
            this.txtNew.Size = new System.Drawing.Size(239, 23);
            this.txtNew.TabIndex = 14;
            this.txtNew.UseSelectable = true;
            this.txtNew.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNew.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(6, 196);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 3);
            this.panel4.TabIndex = 13;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Enabled = false;
            this.metroLabel3.Location = new System.Drawing.Point(22, 208);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Stocks To Add";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // txtAdd
            // 
            // 
            // 
            // 
            this.txtAdd.CustomButton.Image = null;
            this.txtAdd.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtAdd.CustomButton.Name = "";
            this.txtAdd.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAdd.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAdd.CustomButton.TabIndex = 1;
            this.txtAdd.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAdd.CustomButton.UseSelectable = true;
            this.txtAdd.CustomButton.Visible = false;
            this.txtAdd.Enabled = false;
            this.txtAdd.Lines = new string[0];
            this.txtAdd.Location = new System.Drawing.Point(22, 233);
            this.txtAdd.MaxLength = 32767;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.PasswordChar = '\0';
            this.txtAdd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAdd.SelectedText = "";
            this.txtAdd.SelectionLength = 0;
            this.txtAdd.SelectionStart = 0;
            this.txtAdd.ShortcutsEnabled = true;
            this.txtAdd.Size = new System.Drawing.Size(239, 23);
            this.txtAdd.TabIndex = 11;
            this.txtAdd.UseSelectable = true;
            this.txtAdd.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAdd.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtAdd.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            this.txtAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAdd_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(22, 329);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(237, 65);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD STOCKS";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.Location = new System.Drawing.Point(22, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Current Stocks";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // txtStocks
            // 
            // 
            // 
            // 
            this.txtStocks.CustomButton.Image = null;
            this.txtStocks.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtStocks.CustomButton.Name = "";
            this.txtStocks.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStocks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStocks.CustomButton.TabIndex = 1;
            this.txtStocks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStocks.CustomButton.UseSelectable = true;
            this.txtStocks.CustomButton.Visible = false;
            this.txtStocks.Enabled = false;
            this.txtStocks.Lines = new string[0];
            this.txtStocks.Location = new System.Drawing.Point(22, 162);
            this.txtStocks.MaxLength = 32767;
            this.txtStocks.Name = "txtStocks";
            this.txtStocks.PasswordChar = '\0';
            this.txtStocks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStocks.SelectedText = "";
            this.txtStocks.SelectionLength = 0;
            this.txtStocks.SelectionStart = 0;
            this.txtStocks.ShortcutsEnabled = true;
            this.txtStocks.Size = new System.Drawing.Size(239, 23);
            this.txtStocks.TabIndex = 8;
            this.txtStocks.UseSelectable = true;
            this.txtStocks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStocks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(22, 84);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(75, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Item Name";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // txtName
            // 
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(22, 109);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(239, 23);
            this.txtName.TabIndex = 2;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(22, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(71, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Item Code";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // txtCode
            // 
            // 
            // 
            // 
            this.txtCode.CustomButton.Image = null;
            this.txtCode.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Enabled = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(22, 58);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(239, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ucStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.panel3);
            this.Name = "ucStocks";
            this.Size = new System.Drawing.Size(849, 582);
            this.Load += new System.EventHandler(this.ucStocks_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtNew;
        private System.Windows.Forms.Panel panel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAdd;
        private MetroFramework.Controls.MetroTile btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtStocks;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCode;
    }
}
