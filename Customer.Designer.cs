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
            SearchCustomerTab = new TabPage();
            SearchButton = new Button();
            CustomerData = new DataGridView();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            CustomerTabControl = new TabControl();
            SearchCustomerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerData).BeginInit();
            CustomerTabControl.SuspendLayout();
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
            // SearchCustomerTab
            // 
            SearchCustomerTab.Controls.Add(SearchButton);
            SearchCustomerTab.Controls.Add(CustomerData);
            SearchCustomerTab.Controls.Add(LastNameTextBox);
            SearchCustomerTab.Controls.Add(FirstNameTextBox);
            SearchCustomerTab.Controls.Add(LastNameLabel);
            SearchCustomerTab.Controls.Add(FirstNameLabel);
            SearchCustomerTab.Location = new Point(4, 24);
            SearchCustomerTab.Name = "SearchCustomerTab";
            SearchCustomerTab.Padding = new Padding(3);
            SearchCustomerTab.Size = new Size(670, 300);
            SearchCustomerTab.TabIndex = 0;
            SearchCustomerTab.Text = "Search";
            SearchCustomerTab.UseVisualStyleBackColor = true;
            SearchCustomerTab.Click += SearchCustomerTab_Click;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(301, 29);
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
            LastNameTextBox.Location = new Point(159, 30);
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
            LastNameLabel.Location = new Point(159, 12);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(63, 15);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "Last Name";
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
            CustomerTabControl.Controls.Add(SearchCustomerTab);
            CustomerTabControl.Location = new Point(1, 0);
            CustomerTabControl.Name = "CustomerTabControl";
            CustomerTabControl.SelectedIndex = 0;
            CustomerTabControl.Size = new Size(678, 328);
            CustomerTabControl.TabIndex = 1;
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
            SearchCustomerTab.ResumeLayout(false);
            SearchCustomerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CustomerData).EndInit();
            CustomerTabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Home_Button;
        private TabPage SearchCustomerTab;
        private DataGridView CustomerData;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private TabControl CustomerTabControl;
        private Button SearchButton;
    }
}