namespace Inventory_System
{
    partial class ucItems
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnUpdate = new MetroFramework.Controls.MetroTile();
            this.btnDelete = new MetroFramework.Controls.MetroTile();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtStocks = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtPrice = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalItem = new System.Windows.Forms.Label();
            this.lstItems = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 80);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "ITEMS";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Inventory_System.Properties.Resources.appbar_barcode;
            this.pictureBox2.Location = new System.Drawing.Point(14, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(67, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(-1, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 36);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 80);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtStocks);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 400);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ITEM DETAILS";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ActiveControl = null;
            this.btnRefresh.Location = new System.Drawing.Point(103, 321);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 65);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.UseSelectable = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ActiveControl = null;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(22, 321);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 65);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveControl = null;
            this.btnDelete.BackColor = System.Drawing.Color.Maroon;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(184, 321);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 65);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.UseCustomBackColor = true;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Location = new System.Drawing.Point(24, 250);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(237, 65);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Location = new System.Drawing.Point(22, 186);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(45, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Stocks";
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
            this.txtStocks.Lines = new string[0];
            this.txtStocks.Location = new System.Drawing.Point(22, 211);
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
            this.txtStocks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStocks_KeyPress);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(22, 135);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(38, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "Price";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // txtPrice
            // 
            // 
            // 
            // 
            this.txtPrice.CustomButton.Image = null;
            this.txtPrice.CustomButton.Location = new System.Drawing.Point(217, 1);
            this.txtPrice.CustomButton.Name = "";
            this.txtPrice.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrice.CustomButton.TabIndex = 1;
            this.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrice.CustomButton.UseSelectable = true;
            this.txtPrice.CustomButton.Visible = false;
            this.txtPrice.Lines = new string[0];
            this.txtPrice.Location = new System.Drawing.Point(22, 160);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrice.SelectedText = "";
            this.txtPrice.SelectionLength = 0;
            this.txtPrice.SelectionStart = 0;
            this.txtPrice.ShortcutsEnabled = true;
            this.txtPrice.Size = new System.Drawing.Size(239, 23);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.UseSelectable = true;
            this.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrice.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrice_KeyPress);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Inventory_System.Properties.Resources.appbar_social_twitter_hashtag;
            this.pictureBox1.Location = new System.Drawing.Point(25, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Total Item";
            // 
            // lblTotalItem
            // 
            this.lblTotalItem.AutoSize = true;
            this.lblTotalItem.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalItem.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalItem.ForeColor = System.Drawing.Color.Black;
            this.lblTotalItem.Location = new System.Drawing.Point(98, 120);
            this.lblTotalItem.Name = "lblTotalItem";
            this.lblTotalItem.Size = new System.Drawing.Size(51, 28);
            this.lblTotalItem.TabIndex = 15;
            this.lblTotalItem.Text = "143";
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
            this.lstItems.Location = new System.Drawing.Point(294, 117);
            this.lstItems.MultiSelect = false;
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(539, 449);
            this.lstItems.TabIndex = 16;
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
            this.txtSearch.Location = new System.Drawing.Point(386, 88);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(239, 23);
            this.txtSearch.TabIndex = 17;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel5.Location = new System.Drawing.Point(294, 92);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 18;
            this.metroLabel5.Text = "Search Items:";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // ucItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.lblTotalItem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucItems";
            this.Size = new System.Drawing.Size(849, 582);
            this.Load += new System.EventHandler(this.ucItems_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtStocks;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtPrice;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTile btnUpdate;
        private MetroFramework.Controls.MetroTile btnDelete;
        private MetroFramework.Controls.MetroTile btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalItem;
        private System.Windows.Forms.ListView lstItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private MetroFramework.Controls.MetroTile btnRefresh;
    }
}
