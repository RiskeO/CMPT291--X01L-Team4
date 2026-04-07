namespace Movie_Rental_System
{
    partial class Customer
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
            Home_Button = new Button();
            SearchDeleteCustomerTab = new TabPage();
            DeleteButton = new Button();
            SearchButton = new Button();
            CustomerData = new DataGridView();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            CustomerTabControl = new TabControl();
            AddCustomerTab = new TabPage();
            AddCustomerButton = new Button();
            CcardCvvTextBox = new TextBox();
            CcardCvvLabel = new Label();
            CcardExpTextBox = new TextBox();
            CcardExpLabel = new Label();
            CcardNumTextBox = new TextBox();
            CcardNumLabel = new Label();
            AccNumTextBox = new TextBox();
            AccNumLabel = new Label();
            EmailTextBox = new TextBox();
            EmailLabel = new Label();
            PcodeTextBox = new TextBox();
            PcodeLabel = new Label();
            ProvinceTextBox = new TextBox();
            ProvinceLabel = new Label();
            CityTextBox = new TextBox();
            CityLabel = new Label();
            AddressTextBox = new TextBox();
            AddressLabel = new Label();
            LastNameTextBox2 = new TextBox();
            LastNameLabel2 = new Label();
            FirstNameTextBox2 = new TextBox();
            FirstNameLabel2 = new Label();
            CustIdTextBox = new TextBox();
            CustIdLabel = new Label();
            SearchDeleteCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerData).BeginInit();
            CustomerTabControl.SuspendLayout();
            AddCustomerTab.SuspendLayout();
            SuspendLayout();
            // 
            // Home_Button
            // 
            Home_Button.BackColor = Color.Green;
            Home_Button.ForeColor = SystemColors.ControlLightLight;
            Home_Button.Location = new Point(591, 0);
            Home_Button.Name = "Home_Button";
            Home_Button.Size = new Size(88, 21);
            Home_Button.TabIndex = 0;
            Home_Button.Text = "Home";
            Home_Button.UseVisualStyleBackColor = false;
            Home_Button.Click += button1_Click;
            // 
            // SearchDeleteCustomerTab
            // 
            SearchDeleteCustomerTab.Controls.Add(CustIdLabel);
            SearchDeleteCustomerTab.Controls.Add(CustIdTextBox);
            SearchDeleteCustomerTab.Controls.Add(DeleteButton);
            SearchDeleteCustomerTab.Controls.Add(SearchButton);
            SearchDeleteCustomerTab.Controls.Add(CustomerData);
            SearchDeleteCustomerTab.Controls.Add(LastNameTextBox);
            SearchDeleteCustomerTab.Controls.Add(FirstNameTextBox);
            SearchDeleteCustomerTab.Controls.Add(LastNameLabel);
            SearchDeleteCustomerTab.Controls.Add(FirstNameLabel);
            SearchDeleteCustomerTab.Location = new Point(4, 24);
            SearchDeleteCustomerTab.Name = "SearchDeleteCustomerTab";
            SearchDeleteCustomerTab.Padding = new Padding(3);
            SearchDeleteCustomerTab.Size = new Size(670, 300);
            SearchDeleteCustomerTab.TabIndex = 0;
            SearchDeleteCustomerTab.Text = "Search/Delete";
            SearchDeleteCustomerTab.UseVisualStyleBackColor = true;
            SearchDeleteCustomerTab.Click += SearchCustomerTab_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(566, 30);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 23);
            DeleteButton.TabIndex = 6;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(238, 30);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(85, 23);
            SearchButton.TabIndex = 5;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            SearchButton.Click += SearchButton_Click;
            // 
            // CustomerData
            // 
            CustomerData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CustomerData.Location = new Point(6, 77);
            CustomerData.Name = "CustomerData";
            CustomerData.Size = new Size(658, 150);
            CustomerData.TabIndex = 4;
            CustomerData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(122, 30);
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(100, 23);
            LastNameTextBox.TabIndex = 3;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(7, 30);
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(100, 23);
            FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(122, 12);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name";
            LastNameLabel.Click += LastNameLabel_Click;
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(7, 12);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(64, 15);
            FirstNameLabel.TabIndex = 0;
            FirstNameLabel.Text = "First Name";
            FirstNameLabel.Click += label1_Click;
            // 
            // CustomerTabControl
            // 
            CustomerTabControl.Controls.Add(SearchDeleteCustomerTab);
            CustomerTabControl.Controls.Add(AddCustomerTab);
            CustomerTabControl.Location = new Point(1, 0);
            CustomerTabControl.Name = "CustomerTabControl";
            CustomerTabControl.SelectedIndex = 0;
            CustomerTabControl.Size = new Size(678, 328);
            CustomerTabControl.TabIndex = 1;
            // 
            // AddCustomerTab
            // 
            AddCustomerTab.Controls.Add(AddCustomerButton);
            AddCustomerTab.Controls.Add(CcardCvvTextBox);
            AddCustomerTab.Controls.Add(CcardCvvLabel);
            AddCustomerTab.Controls.Add(CcardExpTextBox);
            AddCustomerTab.Controls.Add(CcardExpLabel);
            AddCustomerTab.Controls.Add(CcardNumTextBox);
            AddCustomerTab.Controls.Add(CcardNumLabel);
            AddCustomerTab.Controls.Add(AccNumTextBox);
            AddCustomerTab.Controls.Add(AccNumLabel);
            AddCustomerTab.Controls.Add(EmailTextBox);
            AddCustomerTab.Controls.Add(EmailLabel);
            AddCustomerTab.Controls.Add(PcodeTextBox);
            AddCustomerTab.Controls.Add(PcodeLabel);
            AddCustomerTab.Controls.Add(ProvinceTextBox);
            AddCustomerTab.Controls.Add(ProvinceLabel);
            AddCustomerTab.Controls.Add(CityTextBox);
            AddCustomerTab.Controls.Add(CityLabel);
            AddCustomerTab.Controls.Add(AddressTextBox);
            AddCustomerTab.Controls.Add(AddressLabel);
            AddCustomerTab.Controls.Add(LastNameTextBox2);
            AddCustomerTab.Controls.Add(LastNameLabel2);
            AddCustomerTab.Controls.Add(FirstNameTextBox2);
            AddCustomerTab.Controls.Add(FirstNameLabel2);
            AddCustomerTab.Location = new Point(4, 24);
            AddCustomerTab.Name = "AddCustomerTab";
            AddCustomerTab.Padding = new Padding(3);
            AddCustomerTab.Size = new Size(670, 300);
            AddCustomerTab.TabIndex = 1;
            AddCustomerTab.Text = "Add";
            AddCustomerTab.UseVisualStyleBackColor = true;
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.BackColor = Color.DarkGray;
            AddCustomerButton.Location = new Point(535, 72);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(100, 23);
            AddCustomerButton.TabIndex = 22;
            AddCustomerButton.Text = "Add Customer";
            AddCustomerButton.UseVisualStyleBackColor = false;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // CcardCvvTextBox
            // 
            CcardCvvTextBox.Location = new Point(429, 73);
            CcardCvvTextBox.Name = "CcardCvvTextBox";
            CcardCvvTextBox.Size = new Size(100, 23);
            CcardCvvTextBox.TabIndex = 21;
            // 
            // CcardCvvLabel
            // 
            CcardCvvLabel.AutoSize = true;
            CcardCvvLabel.Location = new Point(429, 55);
            CcardCvvLabel.Name = "CcardCvvLabel";
            CcardCvvLabel.Size = new Size(95, 15);
            CcardCvvLabel.TabIndex = 20;
            CcardCvvLabel.Text = "Credit Card Cvv*";
            // 
            // CcardExpTextBox
            // 
            CcardExpTextBox.Location = new Point(323, 73);
            CcardExpTextBox.Name = "CcardExpTextBox";
            CcardExpTextBox.Size = new Size(100, 23);
            CcardExpTextBox.TabIndex = 19;
            // 
            // CcardExpLabel
            // 
            CcardExpLabel.AutoSize = true;
            CcardExpLabel.Location = new Point(323, 55);
            CcardExpLabel.Name = "CcardExpLabel";
            CcardExpLabel.Size = new Size(93, 15);
            CcardExpLabel.TabIndex = 18;
            CcardExpLabel.Text = "Credit Card Exp*";
            // 
            // CcardNumTextBox
            // 
            CcardNumTextBox.Location = new Point(217, 73);
            CcardNumTextBox.Name = "CcardNumTextBox";
            CcardNumTextBox.Size = new Size(100, 23);
            CcardNumTextBox.TabIndex = 17;
            // 
            // CcardNumLabel
            // 
            CcardNumLabel.AutoSize = true;
            CcardNumLabel.Location = new Point(217, 55);
            CcardNumLabel.Name = "CcardNumLabel";
            CcardNumLabel.Size = new Size(82, 15);
            CcardNumLabel.TabIndex = 16;
            CcardNumLabel.Text = "Credit Card #*";
            // 
            // AccNumTextBox
            // 
            AccNumTextBox.Location = new Point(111, 73);
            AccNumTextBox.Name = "AccNumTextBox";
            AccNumTextBox.Size = new Size(100, 23);
            AccNumTextBox.TabIndex = 15;
            // 
            // AccNumLabel
            // 
            AccNumLabel.AutoSize = true;
            AccNumLabel.Location = new Point(111, 55);
            AccNumLabel.Name = "AccNumLabel";
            AccNumLabel.Size = new Size(67, 15);
            AccNumLabel.TabIndex = 14;
            AccNumLabel.Text = "Account #*";
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(5, 73);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(100, 23);
            EmailTextBox.TabIndex = 13;
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(5, 55);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(41, 15);
            EmailLabel.TabIndex = 12;
            EmailLabel.Text = "Email*";
            // 
            // PcodeTextBox
            // 
            PcodeTextBox.Location = new Point(535, 19);
            PcodeTextBox.Name = "PcodeTextBox";
            PcodeTextBox.Size = new Size(100, 23);
            PcodeTextBox.TabIndex = 11;
            // 
            // PcodeLabel
            // 
            PcodeLabel.AutoSize = true;
            PcodeLabel.Location = new Point(535, 3);
            PcodeLabel.Name = "PcodeLabel";
            PcodeLabel.Size = new Size(70, 15);
            PcodeLabel.TabIndex = 10;
            PcodeLabel.Text = "Postal Code";
            // 
            // ProvinceTextBox
            // 
            ProvinceTextBox.Location = new Point(429, 19);
            ProvinceTextBox.Name = "ProvinceTextBox";
            ProvinceTextBox.Size = new Size(100, 23);
            ProvinceTextBox.TabIndex = 9;
            ProvinceTextBox.TextChanged += ProvinceTextBox_TextChanged;
            // 
            // ProvinceLabel
            // 
            ProvinceLabel.AutoSize = true;
            ProvinceLabel.Location = new Point(429, 3);
            ProvinceLabel.Name = "ProvinceLabel";
            ProvinceLabel.Size = new Size(53, 15);
            ProvinceLabel.TabIndex = 8;
            ProvinceLabel.Text = "Province";
            // 
            // CityTextBox
            // 
            CityTextBox.Location = new Point(323, 19);
            CityTextBox.Name = "CityTextBox";
            CityTextBox.Size = new Size(100, 23);
            CityTextBox.TabIndex = 7;
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new Point(323, 3);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new Size(28, 15);
            CityLabel.TabIndex = 6;
            CityLabel.Text = "City";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(217, 19);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(100, 23);
            AddressTextBox.TabIndex = 5;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(217, 3);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(49, 15);
            AddressLabel.TabIndex = 4;
            AddressLabel.Text = "Address";
            // 
            // LastNameTextBox2
            // 
            LastNameTextBox2.Location = new Point(111, 19);
            LastNameTextBox2.Name = "LastNameTextBox2";
            LastNameTextBox2.Size = new Size(100, 23);
            LastNameTextBox2.TabIndex = 3;
            // 
            // LastNameLabel2
            // 
            LastNameLabel2.AutoSize = true;
            LastNameLabel2.Location = new Point(111, 3);
            LastNameLabel2.Name = "LastNameLabel2";
            LastNameLabel2.Size = new Size(68, 15);
            LastNameLabel2.TabIndex = 2;
            LastNameLabel2.Text = "Last Name*";
            // 
            // FirstNameTextBox2
            // 
            FirstNameTextBox2.Location = new Point(5, 19);
            FirstNameTextBox2.Name = "FirstNameTextBox2";
            FirstNameTextBox2.Size = new Size(100, 23);
            FirstNameTextBox2.TabIndex = 1;
            // 
            // FirstNameLabel2
            // 
            FirstNameLabel2.AutoSize = true;
            FirstNameLabel2.Location = new Point(3, 3);
            FirstNameLabel2.Name = "FirstNameLabel2";
            FirstNameLabel2.Size = new Size(69, 15);
            FirstNameLabel2.TabIndex = 0;
            FirstNameLabel2.Text = "First Name*";
            FirstNameLabel2.Click += label1_Click_1;
            // 
            // CustIdTextBox
            // 
            CustIdTextBox.Location = new Point(460, 30);
            CustIdTextBox.Name = "CustIdTextBox";
            CustIdTextBox.Size = new Size(100, 23);
            CustIdTextBox.TabIndex = 7;
            CustIdTextBox.TextChanged += CustIdTextBox_TextChanged;
            // 
            // CustIdLabel
            // 
            CustIdLabel.AutoSize = true;
            CustIdLabel.Location = new Point(460, 12);
            CustIdLabel.Name = "CustIdLabel";
            CustIdLabel.Size = new Size(73, 15);
            CustIdLabel.TabIndex = 8;
            CustIdLabel.Text = "Customer ID";
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 340);
            Controls.Add(Home_Button);
            Controls.Add(CustomerTabControl);
            Name = "Customer";
            Text = "Customer";
            SearchDeleteCustomerTab.ResumeLayout(false);
            SearchDeleteCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerData).EndInit();
            CustomerTabControl.ResumeLayout(false);
            AddCustomerTab.ResumeLayout(false);
            AddCustomerTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Home_Button;
        private TabPage SearchDeleteCustomerTab;
        private DataGridView CustomerData;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private TabControl CustomerTabControl;
        private Button SearchButton;
        private TabPage AddCustomerTab;
        private Label FirstNameLabel2;
        private Label AddressLabel;
        private TextBox LastNameTextBox2;
        private Label LastNameLabel2;
        private TextBox FirstNameTextBox2;
        private TextBox ProvinceTextBox;
        private Label ProvinceLabel;
        private TextBox CityTextBox;
        private Label CityLabel;
        private TextBox AddressTextBox;
        private Label EmailLabel;
        private TextBox PcodeTextBox;
        private Label PcodeLabel;
        private TextBox CcardExpTextBox;
        private Label CcardExpLabel;
        private TextBox CcardNumTextBox;
        private Label CcardNumLabel;
        private TextBox AccNumTextBox;
        private Label AccNumLabel;
        private TextBox EmailTextBox;
        private Button AddCustomerButton;
        private TextBox CcardCvvTextBox;
        private Label CcardCvvLabel;
        private Button DeleteButton;
        private Label CustIdLabel;
        private TextBox CustIdTextBox;
    }
}