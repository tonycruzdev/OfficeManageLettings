
namespace ManageHomeForms.Forms
{
    partial class FormHomeDetail
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
            System.Windows.Forms.Label address1Label;
            System.Windows.Forms.Label dateFromLabel;
            System.Windows.Forms.Label dateToLabel;
            System.Windows.Forms.Label tenant1Label;
            System.Windows.Forms.Label tenant2Label;
            System.Windows.Forms.Label rentLabel;
            System.Windows.Forms.Label depositLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label mobileLabel;
            System.Windows.Forms.Label landlordIdLabel;
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBoxLandlord = new System.Windows.Forms.ComboBox();
            this.dateToDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.houseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateFromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.address5TextBox = new System.Windows.Forms.TextBox();
            this.address4TextBox = new System.Windows.Forms.TextBox();
            this.address3TextBox = new System.Windows.Forms.TextBox();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.rentTextBox = new System.Windows.Forms.TextBox();
            this.tenant2TextBox = new System.Windows.Forms.TextBox();
            this.tenant1TextBox = new System.Windows.Forms.TextBox();
            this.landlordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            address1Label = new System.Windows.Forms.Label();
            dateFromLabel = new System.Windows.Forms.Label();
            dateToLabel = new System.Windows.Forms.Label();
            tenant1Label = new System.Windows.Forms.Label();
            tenant2Label = new System.Windows.Forms.Label();
            rentLabel = new System.Windows.Forms.Label();
            depositLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            mobileLabel = new System.Windows.Forms.Label();
            landlordIdLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landlordBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // address1Label
            // 
            address1Label.AutoSize = true;
            address1Label.Location = new System.Drawing.Point(58, 19);
            address1Label.Name = "address1Label";
            address1Label.Size = new System.Drawing.Size(66, 18);
            address1Label.TabIndex = 0;
            address1Label.Text = "Address:";
            // 
            // dateFromLabel
            // 
            dateFromLabel.AutoSize = true;
            dateFromLabel.Location = new System.Drawing.Point(49, 181);
            dateFromLabel.Name = "dateFromLabel";
            dateFromLabel.Size = new System.Drawing.Size(83, 18);
            dateFromLabel.TabIndex = 7;
            dateFromLabel.Text = "Date From:";
            // 
            // dateToLabel
            // 
            dateToLabel.AutoSize = true;
            dateToLabel.Location = new System.Drawing.Point(67, 220);
            dateToLabel.Name = "dateToLabel";
            dateToLabel.Size = new System.Drawing.Size(65, 18);
            dateToLabel.TabIndex = 9;
            dateToLabel.Text = "Date To:";
            // 
            // tenant1Label
            // 
            tenant1Label.AutoSize = true;
            tenant1Label.Location = new System.Drawing.Point(39, 9);
            tenant1Label.Name = "tenant1Label";
            tenant1Label.Size = new System.Drawing.Size(69, 18);
            tenant1Label.TabIndex = 0;
            tenant1Label.Text = "Tenant 1:";
            // 
            // tenant2Label
            // 
            tenant2Label.AutoSize = true;
            tenant2Label.Location = new System.Drawing.Point(35, 39);
            tenant2Label.Name = "tenant2Label";
            tenant2Label.Size = new System.Drawing.Size(69, 18);
            tenant2Label.TabIndex = 2;
            tenant2Label.Text = "Tenant 2:";
            // 
            // rentLabel
            // 
            rentLabel.AutoSize = true;
            rentLabel.Location = new System.Drawing.Point(52, 84);
            rentLabel.Name = "rentLabel";
            rentLabel.Size = new System.Drawing.Size(43, 18);
            rentLabel.TabIndex = 4;
            rentLabel.Text = "Rent:";
            // 
            // depositLabel
            // 
            depositLabel.AutoSize = true;
            depositLabel.Location = new System.Drawing.Point(41, 114);
            depositLabel.Name = "depositLabel";
            depositLabel.Size = new System.Drawing.Size(63, 18);
            depositLabel.TabIndex = 6;
            depositLabel.Text = "Deposit:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(55, 162);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(49, 18);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // mobileLabel
            // 
            mobileLabel.AutoSize = true;
            mobileLabel.Location = new System.Drawing.Point(48, 192);
            mobileLabel.Name = "mobileLabel";
            mobileLabel.Size = new System.Drawing.Size(56, 18);
            mobileLabel.TabIndex = 10;
            mobileLabel.Text = "Mobile:";
            // 
            // landlordIdLabel
            // 
            landlordIdLabel.AutoSize = true;
            landlordIdLabel.Location = new System.Drawing.Point(361, 221);
            landlordIdLabel.Name = "landlordIdLabel";
            landlordIdLabel.Size = new System.Drawing.Size(69, 18);
            landlordIdLabel.TabIndex = 11;
            landlordIdLabel.Text = "Landlord:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(74, 31);
            this.tabControl1.Location = new System.Drawing.Point(2, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 300);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.comboBoxLandlord);
            this.tabPage1.Controls.Add(landlordIdLabel);
            this.tabPage1.Controls.Add(dateToLabel);
            this.tabPage1.Controls.Add(this.dateToDateTimePicker);
            this.tabPage1.Controls.Add(dateFromLabel);
            this.tabPage1.Controls.Add(this.dateFromDateTimePicker);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.address5TextBox);
            this.tabPage1.Controls.Add(this.address4TextBox);
            this.tabPage1.Controls.Add(this.address3TextBox);
            this.tabPage1.Controls.Add(this.address2TextBox);
            this.tabPage1.Controls.Add(address1Label);
            this.tabPage1.Controls.Add(this.address1TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Property Detail";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBoxLandlord
            // 
            this.comboBoxLandlord.FormattingEnabled = true;
            this.comboBoxLandlord.Location = new System.Drawing.Point(436, 217);
            this.comboBoxLandlord.Name = "comboBoxLandlord";
            this.comboBoxLandlord.Size = new System.Drawing.Size(249, 26);
            this.comboBoxLandlord.TabIndex = 12;
            // 
            // dateToDateTimePicker
            // 
            this.dateToDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.houseBindingSource, "DateTo", true));
            this.dateToDateTimePicker.Location = new System.Drawing.Point(138, 216);
            this.dateToDateTimePicker.Name = "dateToDateTimePicker";
            this.dateToDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateToDateTimePicker.TabIndex = 10;
            // 
            // houseBindingSource
            // 
            this.houseBindingSource.DataSource = typeof(LettingApiLib.Models.House);
            // 
            // dateFromDateTimePicker
            // 
            this.dateFromDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.houseBindingSource, "DateFrom", true));
            this.dateFromDateTimePicker.Location = new System.Drawing.Point(138, 177);
            this.dateFromDateTimePicker.Name = "dateFromDateTimePicker";
            this.dateFromDateTimePicker.Size = new System.Drawing.Size(200, 24);
            this.dateFromDateTimePicker.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Location = new System.Drawing.Point(5, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(978, 2);
            this.panel1.TabIndex = 7;
            // 
            // address5TextBox
            // 
            this.address5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Address5", true));
            this.address5TextBox.Location = new System.Drawing.Point(138, 136);
            this.address5TextBox.Name = "address5TextBox";
            this.address5TextBox.Size = new System.Drawing.Size(547, 24);
            this.address5TextBox.TabIndex = 6;
            // 
            // address4TextBox
            // 
            this.address4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Address4", true));
            this.address4TextBox.Location = new System.Drawing.Point(138, 106);
            this.address4TextBox.Name = "address4TextBox";
            this.address4TextBox.Size = new System.Drawing.Size(547, 24);
            this.address4TextBox.TabIndex = 5;
            // 
            // address3TextBox
            // 
            this.address3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Address3", true));
            this.address3TextBox.Location = new System.Drawing.Point(138, 76);
            this.address3TextBox.Name = "address3TextBox";
            this.address3TextBox.Size = new System.Drawing.Size(547, 24);
            this.address3TextBox.TabIndex = 4;
            // 
            // address2TextBox
            // 
            this.address2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Address2", true));
            this.address2TextBox.Location = new System.Drawing.Point(138, 46);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(547, 24);
            this.address2TextBox.TabIndex = 3;
            // 
            // address1TextBox
            // 
            this.address1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Address1", true));
            this.address1TextBox.Location = new System.Drawing.Point(138, 16);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(547, 24);
            this.address1TextBox.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(mobileLabel);
            this.tabPage2.Controls.Add(this.mobileTextBox);
            this.tabPage2.Controls.Add(emailLabel);
            this.tabPage2.Controls.Add(this.emailTextBox);
            this.tabPage2.Controls.Add(depositLabel);
            this.tabPage2.Controls.Add(this.depositTextBox);
            this.tabPage2.Controls.Add(rentLabel);
            this.tabPage2.Controls.Add(this.rentTextBox);
            this.tabPage2.Controls.Add(tenant2Label);
            this.tabPage2.Controls.Add(this.tenant2TextBox);
            this.tabPage2.Controls.Add(tenant1Label);
            this.tabPage2.Controls.Add(this.tenant1TextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "More Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(6, 147);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(978, 2);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(6, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(978, 2);
            this.panel2.TabIndex = 12;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Mobile", true));
            this.mobileTextBox.Location = new System.Drawing.Point(110, 189);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(335, 24);
            this.mobileTextBox.TabIndex = 11;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(110, 159);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(335, 24);
            this.emailTextBox.TabIndex = 9;
            // 
            // depositTextBox
            // 
            this.depositTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Deposit", true));
            this.depositTextBox.Location = new System.Drawing.Point(110, 111);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(175, 24);
            this.depositTextBox.TabIndex = 7;
            // 
            // rentTextBox
            // 
            this.rentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Rent", true));
            this.rentTextBox.Location = new System.Drawing.Point(110, 78);
            this.rentTextBox.Name = "rentTextBox";
            this.rentTextBox.Size = new System.Drawing.Size(175, 24);
            this.rentTextBox.TabIndex = 5;
            // 
            // tenant2TextBox
            // 
            this.tenant2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Tenant2", true));
            this.tenant2TextBox.Location = new System.Drawing.Point(110, 36);
            this.tenant2TextBox.Name = "tenant2TextBox";
            this.tenant2TextBox.Size = new System.Drawing.Size(335, 24);
            this.tenant2TextBox.TabIndex = 3;
            // 
            // tenant1TextBox
            // 
            this.tenant1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.houseBindingSource, "Tenant1", true));
            this.tenant1TextBox.Location = new System.Drawing.Point(110, 6);
            this.tenant1TextBox.Name = "tenant1TextBox";
            this.tenant1TextBox.Size = new System.Drawing.Size(335, 24);
            this.tenant1TextBox.TabIndex = 1;
            // 
            // landlordBindingSource
            // 
            this.landlordBindingSource.DataSource = typeof(LettingApiLib.Models.Landlord);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(861, 323);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 36);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(13, 323);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(128, 36);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(13, 320);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(978, 2);
            this.panel4.TabIndex = 8;
            // 
            // FormHomeDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 362);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormHomeDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Detail";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.houseBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.landlordBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox address5TextBox;
        private System.Windows.Forms.BindingSource houseBindingSource;
        private System.Windows.Forms.TextBox address4TextBox;
        private System.Windows.Forms.TextBox address3TextBox;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.DateTimePicker dateToDateTimePicker;
        private System.Windows.Forms.DateTimePicker dateFromDateTimePicker;
        private System.Windows.Forms.BindingSource landlordBindingSource;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox mobileTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.TextBox rentTextBox;
        private System.Windows.Forms.TextBox tenant2TextBox;
        private System.Windows.Forms.TextBox tenant1TextBox;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBoxLandlord;
    }
}