namespace Inventory_System
{
    partial class ucOrders
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new MetroFramework.Controls.MetroTile();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtQuantity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtCode = new MetroFramework.Controls.MetroTextBox();
            this.lstSummary = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtAddress = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroTile();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtContactNumber = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtCustomerName = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new MetroFramework.Controls.MetroTile();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
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
            this.panel3.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Location = new System.Drawing.Point(40, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 80);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(57, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "ORDERS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Location = new System.Drawing.Point(-1, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 36);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 231);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ORDER FORM";
            // 
            // btnAdd
            // 
            this.btnAdd.ActiveControl = null;
            this.btnAdd.Location = new System.Drawing.Point(37, 181);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(253, 41);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "ADD ORDER";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel4.Enabled = false;
            this.metroLabel4.Location = new System.Drawing.Point(37, 127);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Quantity";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // txtQuantity
            // 
            // 
            // 
            // 
            this.txtQuantity.CustomButton.Image = null;
            this.txtQuantity.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtQuantity.CustomButton.Name = "";
            this.txtQuantity.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtQuantity.CustomButton.TabIndex = 1;
            this.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtQuantity.CustomButton.UseSelectable = true;
            this.txtQuantity.CustomButton.Visible = false;
            this.txtQuantity.Lines = new string[0];
            this.txtQuantity.Location = new System.Drawing.Point(37, 152);
            this.txtQuantity.MaxLength = 32767;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.SelectionLength = 0;
            this.txtQuantity.SelectionStart = 0;
            this.txtQuantity.ShortcutsEnabled = true;
            this.txtQuantity.Size = new System.Drawing.Size(253, 23);
            this.txtQuantity.TabIndex = 8;
            this.txtQuantity.UseSelectable = true;
            this.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtQuantity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel2.Location = new System.Drawing.Point(37, 74);
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
            this.txtName.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.Enabled = false;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(37, 99);
            this.txtName.MaxLength = 32767;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(253, 23);
            this.txtName.TabIndex = 2;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.Location = new System.Drawing.Point(37, 23);
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
            this.txtCode.CustomButton.Location = new System.Drawing.Point(170, 1);
            this.txtCode.CustomButton.Name = "";
            this.txtCode.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCode.CustomButton.TabIndex = 1;
            this.txtCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCode.CustomButton.UseSelectable = true;
            this.txtCode.CustomButton.Visible = false;
            this.txtCode.Enabled = false;
            this.txtCode.Lines = new string[0];
            this.txtCode.Location = new System.Drawing.Point(37, 48);
            this.txtCode.MaxLength = 32767;
            this.txtCode.Name = "txtCode";
            this.txtCode.PasswordChar = '\0';
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCode.SelectedText = "";
            this.txtCode.SelectionLength = 0;
            this.txtCode.SelectionStart = 0;
            this.txtCode.ShortcutsEnabled = true;
            this.txtCode.Size = new System.Drawing.Size(192, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.UseSelectable = true;
            this.txtCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lstSummary
            // 
            this.lstSummary.BackColor = System.Drawing.Color.White;
            this.lstSummary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstSummary.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSummary.FullRowSelect = true;
            this.lstSummary.Location = new System.Drawing.Point(356, 168);
            this.lstSummary.MultiSelect = false;
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(478, 358);
            this.lstSummary.TabIndex = 27;
            this.lstSummary.UseCompatibleStateImageBehavior = false;
            this.lstSummary.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "ID";
            this.columnHeader6.Width = 0;
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 0;
            this.columnHeader1.Text = "CODE";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 1;
            this.columnHeader2.Text = "ITEM NAME";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "PRICE";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "QTY";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "SUBTOTAL";
            this.columnHeader5.Width = 100;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(562, 529);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "TOTAL PRICE:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(694, 529);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 23);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "0.00";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.BackColor = System.Drawing.Color.DarkRed;
            this.metroTile1.Location = new System.Drawing.Point(706, 86);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(128, 41);
            this.metroTile1.TabIndex = 31;
            this.metroTile1.Text = "DELETE ITEM";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseCustomBackColor = true;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(566, 86);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(134, 41);
            this.metroTile2.TabIndex = 32;
            this.metroTile2.Text = "CLEAR ALL";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.btnSubmit);
            this.groupBox2.Controls.Add(this.metroLabel6);
            this.groupBox2.Controls.Add(this.txtContactNumber);
            this.groupBox2.Controls.Add(this.metroLabel7);
            this.groupBox2.Controls.Add(this.txtCustomerName);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 323);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 246);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SUBMIT ORDER";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel3.Location = new System.Drawing.Point(38, 127);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Address";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.CustomButton.Image = null;
            this.txtAddress.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtAddress.CustomButton.Name = "";
            this.txtAddress.CustomButton.Size = new System.Drawing.Size(39, 39);
            this.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAddress.CustomButton.TabIndex = 1;
            this.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAddress.CustomButton.UseSelectable = true;
            this.txtAddress.CustomButton.Visible = false;
            this.txtAddress.Lines = new string[0];
            this.txtAddress.Location = new System.Drawing.Point(38, 152);
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(253, 41);
            this.txtAddress.TabIndex = 2;
            this.txtAddress.UseSelectable = true;
            this.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.ActiveControl = null;
            this.btnSubmit.Location = new System.Drawing.Point(40, 199);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(251, 41);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel6.Location = new System.Drawing.Point(38, 76);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(66, 19);
            this.metroLabel6.TabIndex = 3;
            this.metroLabel6.Text = "Contact #";
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // txtContactNumber
            // 
            // 
            // 
            // 
            this.txtContactNumber.CustomButton.Image = null;
            this.txtContactNumber.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtContactNumber.CustomButton.Name = "";
            this.txtContactNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtContactNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtContactNumber.CustomButton.TabIndex = 1;
            this.txtContactNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtContactNumber.CustomButton.UseSelectable = true;
            this.txtContactNumber.CustomButton.Visible = false;
            this.txtContactNumber.Lines = new string[0];
            this.txtContactNumber.Location = new System.Drawing.Point(38, 101);
            this.txtContactNumber.MaxLength = 32767;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.PasswordChar = '\0';
            this.txtContactNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtContactNumber.SelectedText = "";
            this.txtContactNumber.SelectionLength = 0;
            this.txtContactNumber.SelectionStart = 0;
            this.txtContactNumber.ShortcutsEnabled = true;
            this.txtContactNumber.Size = new System.Drawing.Size(253, 23);
            this.txtContactNumber.TabIndex = 1;
            this.txtContactNumber.UseSelectable = true;
            this.txtContactNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtContactNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel7.Location = new System.Drawing.Point(38, 25);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(106, 19);
            this.metroLabel7.TabIndex = 1;
            this.metroLabel7.Text = "Customer Name";
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // txtCustomerName
            // 
            // 
            // 
            // 
            this.txtCustomerName.CustomButton.Image = null;
            this.txtCustomerName.CustomButton.Location = new System.Drawing.Point(231, 1);
            this.txtCustomerName.CustomButton.Name = "";
            this.txtCustomerName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtCustomerName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCustomerName.CustomButton.TabIndex = 1;
            this.txtCustomerName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCustomerName.CustomButton.UseSelectable = true;
            this.txtCustomerName.CustomButton.Visible = false;
            this.txtCustomerName.Lines = new string[0];
            this.txtCustomerName.Location = new System.Drawing.Point(38, 50);
            this.txtCustomerName.MaxLength = 32767;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.PasswordChar = '\0';
            this.txtCustomerName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCustomerName.SelectedText = "";
            this.txtCustomerName.SelectionLength = 0;
            this.txtCustomerName.SelectionStart = 0;
            this.txtCustomerName.ShortcutsEnabled = true;
            this.txtCustomerName.Size = new System.Drawing.Size(253, 23);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.UseSelectable = true;
            this.txtCustomerName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCustomerName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(133)))), ((int)(((byte)(244)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Image = global::Inventory_System.Properties.Resources.appbar_cart;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(356, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 41);
            this.label1.TabIndex = 28;
            this.label1.Text = "ORDER SUMMARY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearch
            // 
            this.btnSearch.ActiveControl = null;
            this.btnSearch.Location = new System.Drawing.Point(235, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 48);
            this.btnSearch.TabIndex = 34;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.TileImage = global::Inventory_System.Properties.Resources.appbar_magnify;
            this.btnSearch.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearch.UseSelectable = true;
            this.btnSearch.UseTileImage = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Inventory_System.Properties.Resources.appbar_cart;
            this.pictureBox4.Location = new System.Drawing.Point(1, 14);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(67, 52);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 6;
            this.pictureBox4.TabStop = false;
            // 
            // ucOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstSummary);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Name = "ucOrders";
            this.Size = new System.Drawing.Size(849, 582);
            this.Load += new System.EventHandler(this.ucOrders_Load);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTile btnAdd;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtQuantity;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtCode;
        private System.Windows.Forms.ListView lstSummary;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile metroTile2;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile btnSubmit;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtContactNumber;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtCustomerName;
        private MetroFramework.Controls.MetroTile btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtAddress;
    }
}
