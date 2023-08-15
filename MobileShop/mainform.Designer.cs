namespace MobileShop
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteMobileRecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomerRecord = new Guna.UI2.WinForms.Guna2Button();
            this.btnStocks = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNewMobile = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_DeleteCustomer1 = new MobileShop.AllUserControl.UC_DeleteCustomer();
            this.uC_CustomerRecord1 = new MobileShop.AllUserControl.UC_CustomerRecord();
            this.uC_Stock1 = new MobileShop.AllUserControl.UC_Stock();
            this.uC_Customer1 = new MobileShop.AllUserControl.UC_Customer();
            this.uC_AddNewRecord2 = new MobileShop.AllUserControl.UC_AddNewRecord();
            this.uC_Wellcome1 = new MobileShop.AllUserControl.UC_Wellcome();
            this.guna2Elipse6 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Qadri Mobile";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnVerify);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnDeleteMobileRecord);
            this.panel1.Controls.Add(this.btnCustomerRecord);
            this.panel1.Controls.Add(this.btnStocks);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.btnAddNewMobile);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 718);
            this.panel1.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.BlueViolet;
            this.btnCancel.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(156, 636);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 43);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.BlueViolet;
            this.btnVerify.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(39, 636);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(101, 43);
            this.btnVerify.TabIndex = 7;
            this.btnVerify.Text = "Verify";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 10;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.BlueViolet;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Cooper Black", 8F);
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtPassword.Location = new System.Drawing.Point(31, 577);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(234, 37);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Red;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(14, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.Exit_Click_1);
            // 
            // btnDeleteMobileRecord
            // 
            this.btnDeleteMobileRecord.BorderRadius = 15;
            this.btnDeleteMobileRecord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDeleteMobileRecord.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeleteMobileRecord.CheckedState.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMobileRecord.CheckedState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnDeleteMobileRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMobileRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteMobileRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteMobileRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteMobileRecord.FillColor = System.Drawing.Color.BlueViolet;
            this.btnDeleteMobileRecord.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMobileRecord.ForeColor = System.Drawing.Color.White;
            this.btnDeleteMobileRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteMobileRecord.Image")));
            this.btnDeleteMobileRecord.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDeleteMobileRecord.Location = new System.Drawing.Point(2, 507);
            this.btnDeleteMobileRecord.Name = "btnDeleteMobileRecord";
            this.btnDeleteMobileRecord.Size = new System.Drawing.Size(314, 62);
            this.btnDeleteMobileRecord.TabIndex = 5;
            this.btnDeleteMobileRecord.Text = "Delete Mobile Record";
            this.btnDeleteMobileRecord.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCustomerRecord
            // 
            this.btnCustomerRecord.BorderRadius = 15;
            this.btnCustomerRecord.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomerRecord.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCustomerRecord.CheckedState.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRecord.CheckedState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnCustomerRecord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRecord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomerRecord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomerRecord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomerRecord.FillColor = System.Drawing.Color.BlueViolet;
            this.btnCustomerRecord.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerRecord.ForeColor = System.Drawing.Color.White;
            this.btnCustomerRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerRecord.Image")));
            this.btnCustomerRecord.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomerRecord.Location = new System.Drawing.Point(2, 428);
            this.btnCustomerRecord.Name = "btnCustomerRecord";
            this.btnCustomerRecord.Size = new System.Drawing.Size(314, 62);
            this.btnCustomerRecord.TabIndex = 4;
            this.btnCustomerRecord.Text = "Customer Record";
            this.btnCustomerRecord.Click += new System.EventHandler(this.btnCustomerRecord_Click);
            // 
            // btnStocks
            // 
            this.btnStocks.BorderRadius = 15;
            this.btnStocks.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStocks.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStocks.CheckedState.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.CheckedState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnStocks.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStocks.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStocks.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStocks.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStocks.FillColor = System.Drawing.Color.BlueViolet;
            this.btnStocks.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStocks.ForeColor = System.Drawing.Color.White;
            this.btnStocks.Image = ((System.Drawing.Image)(resources.GetObject("btnStocks.Image")));
            this.btnStocks.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStocks.Location = new System.Drawing.Point(1, 351);
            this.btnStocks.Name = "btnStocks";
            this.btnStocks.Size = new System.Drawing.Size(314, 62);
            this.btnStocks.TabIndex = 3;
            this.btnStocks.Text = "Stocks";
            this.btnStocks.Click += new System.EventHandler(this.btnStocks_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BorderRadius = 15;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCustomer.CheckedState.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.CheckedState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.BlueViolet;
            this.btnCustomer.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomer.Location = new System.Drawing.Point(1, 265);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(314, 62);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customers";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            this.btnCustomer.Enter += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnAddNewMobile
            // 
            this.btnAddNewMobile.BorderRadius = 15;
            this.btnAddNewMobile.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAddNewMobile.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddNewMobile.CheckedState.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMobile.CheckedState.ForeColor = System.Drawing.Color.BlueViolet;
            this.btnAddNewMobile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewMobile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewMobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewMobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewMobile.FillColor = System.Drawing.Color.BlueViolet;
            this.btnAddNewMobile.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewMobile.ForeColor = System.Drawing.Color.White;
            this.btnAddNewMobile.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewMobile.Image")));
            this.btnAddNewMobile.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddNewMobile.Location = new System.Drawing.Point(2, 186);
            this.btnAddNewMobile.Name = "btnAddNewMobile";
            this.btnAddNewMobile.Size = new System.Drawing.Size(314, 62);
            this.btnAddNewMobile.TabIndex = 1;
            this.btnAddNewMobile.Text = "Add New Mobile";
            this.btnAddNewMobile.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 18F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Shop";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.TargetControl = this;
            // 
            // uC_DeleteCustomer1
            // 
            this.uC_DeleteCustomer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_DeleteCustomer1.Location = new System.Drawing.Point(294, 0);
            this.uC_DeleteCustomer1.Name = "uC_DeleteCustomer1";
            this.uC_DeleteCustomer1.Size = new System.Drawing.Size(1028, 718);
            this.uC_DeleteCustomer1.TabIndex = 10;
            this.uC_DeleteCustomer1.Load += new System.EventHandler(this.uC_DeleteCustomer1_Load);
            // 
            // uC_CustomerRecord1
            // 
            this.uC_CustomerRecord1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_CustomerRecord1.ForeColor = System.Drawing.Color.White;
            this.uC_CustomerRecord1.Location = new System.Drawing.Point(297, 1);
            this.uC_CustomerRecord1.Name = "uC_CustomerRecord1";
            this.uC_CustomerRecord1.Size = new System.Drawing.Size(1028, 717);
            this.uC_CustomerRecord1.TabIndex = 9;
            // 
            // uC_Stock1
            // 
            this.uC_Stock1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_Stock1.Location = new System.Drawing.Point(298, 1);
            this.uC_Stock1.Name = "uC_Stock1";
            this.uC_Stock1.Size = new System.Drawing.Size(1028, 718);
            this.uC_Stock1.TabIndex = 8;
            // 
            // uC_Customer1
            // 
            this.uC_Customer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_Customer1.Font = new System.Drawing.Font("Cooper Black", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_Customer1.Location = new System.Drawing.Point(298, 0);
            this.uC_Customer1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.uC_Customer1.Name = "uC_Customer1";
            this.uC_Customer1.Size = new System.Drawing.Size(1028, 718);
            this.uC_Customer1.TabIndex = 7;
            this.uC_Customer1.Enter += new System.EventHandler(this.btnCustomer_Click);
            // 
            // uC_AddNewRecord2
            // 
            this.uC_AddNewRecord2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_AddNewRecord2.Location = new System.Drawing.Point(296, 0);
            this.uC_AddNewRecord2.Name = "uC_AddNewRecord2";
            this.uC_AddNewRecord2.Size = new System.Drawing.Size(1028, 718);
            this.uC_AddNewRecord2.TabIndex = 6;
            this.uC_AddNewRecord2.Load += new System.EventHandler(this.uC_AddNewRecord2_Load);
            // 
            // uC_Wellcome1
            // 
            this.uC_Wellcome1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uC_Wellcome1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.uC_Wellcome1.Location = new System.Drawing.Point(298, 0);
            this.uC_Wellcome1.Name = "uC_Wellcome1";
            this.uC_Wellcome1.Size = new System.Drawing.Size(1028, 718);
            this.uC_Wellcome1.TabIndex = 11;
            // 
            // guna2Elipse6
            // 
            this.guna2Elipse6.TargetControl = this;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1323, 718);
            this.Controls.Add(this.uC_Wellcome1);
            this.Controls.Add(this.uC_DeleteCustomer1);
            this.Controls.Add(this.uC_CustomerRecord1);
            this.Controls.Add(this.uC_Stock1);
            this.Controls.Add(this.uC_Customer1);
            this.Controls.Add(this.uC_AddNewRecord2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnAddNewMobile;
        private Guna.UI2.WinForms.Guna2Button btnDeleteMobileRecord;
        private Guna.UI2.WinForms.Guna2Button btnCustomerRecord;
        private Guna.UI2.WinForms.Guna2Button btnStocks;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private AllUserControl.UC_AddNewRecord uC_AddNewRecord2;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private AllUserControl.UC_Customer uC_Customer1;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private AllUserControl.UC_Stock uC_Stock1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private AllUserControl.UC_CustomerRecord uC_CustomerRecord1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnVerify;
        private AllUserControl.UC_DeleteCustomer uC_DeleteCustomer1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private AllUserControl.UC_Wellcome uC_Wellcome1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse6;
    }
}