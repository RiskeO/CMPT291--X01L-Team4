namespace Movie_Rental_System
{
    partial class Report
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Report_TabControl = new TabControl();
            Options_Tab = new TabPage();
            Movie_Report_ComboBox = new ComboBox();
            FamilyName = new Label();
            FirstName = new Label();
            Recommend_LastName_TextBox = new TextBox();
            Recommend_FirstName_TextBox = new TextBox();
            Recommend_Movie_Button = new Button();
            Most_Frequent_Customers_Button = new Button();
            Actor_Rating_Button = new Button();
            Sort_Movies_Button = new Button();
            Monthly_Sales_Report_Button = new Button();
            Data_Tab = new TabPage();
            Data = new DataGridView();
            Home_Button = new Button();
            Report_TabControl.SuspendLayout();
            Options_Tab.SuspendLayout();
            Data_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Data).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Report_TabControl
            // 
            Report_TabControl.Controls.Add(Options_Tab);
            Report_TabControl.Controls.Add(Data_Tab);
            Report_TabControl.Location = new Point(-3, 0);
            Report_TabControl.Name = "Report_TabControl";
            Report_TabControl.SelectedIndex = 0;
            Report_TabControl.Size = new Size(788, 457);
            Report_TabControl.TabIndex = 1;
            // 
            // Options_Tab
            // 
            Options_Tab.Controls.Add(Movie_Report_ComboBox);
            Options_Tab.Controls.Add(FamilyName);
            Options_Tab.Controls.Add(FirstName);
            Options_Tab.Controls.Add(Recommend_LastName_TextBox);
            Options_Tab.Controls.Add(Recommend_FirstName_TextBox);
            Options_Tab.Controls.Add(Recommend_Movie_Button);
            Options_Tab.Controls.Add(Most_Frequent_Customers_Button);
            Options_Tab.Controls.Add(Actor_Rating_Button);
            Options_Tab.Controls.Add(Sort_Movies_Button);
            Options_Tab.Controls.Add(Monthly_Sales_Report_Button);
            Options_Tab.Location = new Point(4, 29);
            Options_Tab.Name = "Options_Tab";
            Options_Tab.Padding = new Padding(3);
            Options_Tab.Size = new Size(780, 424);
            Options_Tab.TabIndex = 0;
            Options_Tab.Text = "Options";
            Options_Tab.UseVisualStyleBackColor = true;
            // 
            // Movie_Report_ComboBox
            // 
            Movie_Report_ComboBox.Font = new Font("Segoe UI", 10F);
            Movie_Report_ComboBox.FormattingEnabled = true;
            Movie_Report_ComboBox.ItemHeight = 23;
            Movie_Report_ComboBox.Items.AddRange(new object[] { "Movie Name", "Movie Type", "Rental Price", "Popular Movies" });
            Movie_Report_ComboBox.Location = new Point(38, 220);
            Movie_Report_ComboBox.Name = "Movie_Report_ComboBox";
            Movie_Report_ComboBox.Size = new Size(250, 31);
            Movie_Report_ComboBox.TabIndex = 9;
            Movie_Report_ComboBox.SelectedIndexChanged += Movie_Report_ComboBox_SelectedIndexChanged;
            // 
            // FamilyName
            // 
            FamilyName.AutoSize = true;
            FamilyName.Location = new Point(566, 194);
            FamilyName.Name = "FamilyName";
            FamilyName.Size = new Size(95, 20);
            FamilyName.TabIndex = 8;
            FamilyName.Text = "Family Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(437, 191);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(80, 20);
            FirstName.TabIndex = 7;
            FirstName.Text = "First Name";
            // 
            // Recommend_LastName_TextBox
            // 
            Recommend_LastName_TextBox.Location = new Point(566, 217);
            Recommend_LastName_TextBox.Name = "Recommend_LastName_TextBox";
            Recommend_LastName_TextBox.Size = new Size(121, 27);
            Recommend_LastName_TextBox.TabIndex = 6;
            // 
            // Recommend_FirstName_TextBox
            // 
            Recommend_FirstName_TextBox.Location = new Point(437, 217);
            Recommend_FirstName_TextBox.Name = "Recommend_FirstName_TextBox";
            Recommend_FirstName_TextBox.Size = new Size(121, 27);
            Recommend_FirstName_TextBox.TabIndex = 5;
            // 
            // Recommend_Movie_Button
            // 
            Recommend_Movie_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Recommend_Movie_Button.Location = new Point(437, 250);
            Recommend_Movie_Button.Name = "Recommend_Movie_Button";
            Recommend_Movie_Button.Size = new Size(250, 50);
            Recommend_Movie_Button.TabIndex = 4;
            Recommend_Movie_Button.Text = "Recommended Movie";
            Recommend_Movie_Button.UseVisualStyleBackColor = true;
            Recommend_Movie_Button.Click += Recommended_Movie_Button_Click;
            // 
            // Most_Frequent_Customers_Button
            // 
            Most_Frequent_Customers_Button.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Most_Frequent_Customers_Button.Location = new Point(437, 117);
            Most_Frequent_Customers_Button.Name = "Most_Frequent_Customers_Button";
            Most_Frequent_Customers_Button.Size = new Size(250, 50);
            Most_Frequent_Customers_Button.TabIndex = 3;
            Most_Frequent_Customers_Button.Text = "Most Frequent Customers";
            Most_Frequent_Customers_Button.UseVisualStyleBackColor = true;
            Most_Frequent_Customers_Button.Click += Most_Frequent_Customers_Button_Click;
            // 
            // Actor_Rating_Button
            // 
            Actor_Rating_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Actor_Rating_Button.Location = new Point(38, 268);
            Actor_Rating_Button.Name = "Actor_Rating_Button";
            Actor_Rating_Button.Size = new Size(250, 50);
            Actor_Rating_Button.TabIndex = 2;
            Actor_Rating_Button.Text = "Actor Rating";
            Actor_Rating_Button.UseVisualStyleBackColor = true;
            Actor_Rating_Button.Click += Actor_Rating_Button_Click;
            // 
            // Sort_Movies_Button
            // 
            Sort_Movies_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sort_Movies_Button.Location = new Point(38, 174);
            Sort_Movies_Button.Name = "Sort_Movies_Button";
            Sort_Movies_Button.Size = new Size(250, 50);
            Sort_Movies_Button.TabIndex = 1;
            Sort_Movies_Button.Text = "Sort Movies By: ";
            Sort_Movies_Button.UseVisualStyleBackColor = true;
            Sort_Movies_Button.Click += Sort_Movies_Button_Click;
            // 
            // Monthly_Sales_Report_Button
            // 
            Monthly_Sales_Report_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Monthly_Sales_Report_Button.Location = new Point(38, 105);
            Monthly_Sales_Report_Button.Name = "Monthly_Sales_Report_Button";
            Monthly_Sales_Report_Button.Size = new Size(250, 50);
            Monthly_Sales_Report_Button.TabIndex = 0;
            Monthly_Sales_Report_Button.Text = "Monthly Sales Reports";
            Monthly_Sales_Report_Button.UseVisualStyleBackColor = true;
            Monthly_Sales_Report_Button.Click += Monthly_Sales_Report_Button_Click;
            // 
            // Data_Tab
            // 
            Data_Tab.Controls.Add(Data);
            Data_Tab.Location = new Point(4, 29);
            Data_Tab.Name = "Data_Tab";
            Data_Tab.Padding = new Padding(3);
            Data_Tab.Size = new Size(780, 424);
            Data_Tab.TabIndex = 1;
            Data_Tab.Text = "Data";
            Data_Tab.UseVisualStyleBackColor = true;
            // 
            // Data
            // 
            Data.AllowUserToAddRows = false;
            Data.AllowUserToDeleteRows = false;
            Data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Data.Location = new Point(0, 0);
            Data.Name = "Data";
            Data.ReadOnly = true;
            Data.RowHeadersWidth = 51;
            Data.Size = new Size(780, 421);
            Data.TabIndex = 0;
            // 
            // Home_Button
            // 
            Home_Button.BackColor = Color.Green;
            Home_Button.ForeColor = SystemColors.ControlLightLight;
            Home_Button.Location = new Point(675, 0);
            Home_Button.Name = "Home_Button";
            Home_Button.Size = new Size(100, 28);
            Home_Button.TabIndex = 2;
            Home_Button.Text = "Home";
            Home_Button.UseVisualStyleBackColor = false;
            Home_Button.Click += Home_Button_Click;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Home_Button);
            Controls.Add(Report_TabControl);
            Name = "Report";
            Text = "Report";
            Report_TabControl.ResumeLayout(false);
            Options_Tab.ResumeLayout(false);
            Options_Tab.PerformLayout();
            Data_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl Report_TabControl;
        private TabPage Options_Tab;
        private TabPage Data_Tab;
        private Button Actor_Rating_Button;
        private Button Sort_Movies_Button;
        private Button Monthly_Sales_Report_Button;
        private Button Recommend_Movie_Button;
        private Button Most_Frequent_Customers_Button;
        private DataGridView Data;
        private Button Home_Button;
        private TextBox Recommend_LastName_TextBox;
        private TextBox Recommend_FirstName_TextBox;
        private Label FirstName;
        private Label FamilyName;
        private ComboBox Movie_Report_ComboBox;
    }
}