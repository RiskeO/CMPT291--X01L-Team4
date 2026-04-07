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
            Frequent_Customer_TimePicker = new DateTimePicker();
            Actor_Rating_TimePicker = new DateTimePicker();
            Sort_Movie_TimePicker = new DateTimePicker();
            Sale_Report_Year_Picker = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Movie_Report_ComboBox = new ComboBox();
            Recommend_Movie_Button = new Button();
            Most_Frequent_Customers_Button = new Button();
            Actor_Rating_Button = new Button();
            Type_Movies_Button = new Button();
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
            Options_Tab.Controls.Add(Frequent_Customer_TimePicker);
            Options_Tab.Controls.Add(Actor_Rating_TimePicker);
            Options_Tab.Controls.Add(Sort_Movie_TimePicker);
            Options_Tab.Controls.Add(Sale_Report_Year_Picker);
            Options_Tab.Controls.Add(label6);
            Options_Tab.Controls.Add(label7);
            Options_Tab.Controls.Add(label4);
            Options_Tab.Controls.Add(label3);
            Options_Tab.Controls.Add(label2);
            Options_Tab.Controls.Add(label1);
            Options_Tab.Controls.Add(Movie_Report_ComboBox);
            Options_Tab.Controls.Add(Recommend_Movie_Button);
            Options_Tab.Controls.Add(Most_Frequent_Customers_Button);
            Options_Tab.Controls.Add(Actor_Rating_Button);
            Options_Tab.Controls.Add(Type_Movies_Button);
            Options_Tab.Controls.Add(Monthly_Sales_Report_Button);
            Options_Tab.Location = new Point(4, 29);
            Options_Tab.Name = "Options_Tab";
            Options_Tab.Padding = new Padding(3);
            Options_Tab.Size = new Size(780, 424);
            Options_Tab.TabIndex = 0;
            Options_Tab.Text = "Options";
            Options_Tab.UseVisualStyleBackColor = true;
            // 
            // Frequent_Customer_TimePicker
            // 
            Frequent_Customer_TimePicker.CustomFormat = "MM/yyyy";
            Frequent_Customer_TimePicker.Format = DateTimePickerFormat.Custom;
            Frequent_Customer_TimePicker.Location = new Point(493, 235);
            Frequent_Customer_TimePicker.Name = "Frequent_Customer_TimePicker";
            Frequent_Customer_TimePicker.ShowUpDown = true;
            Frequent_Customer_TimePicker.Size = new Size(250, 27);
            Frequent_Customer_TimePicker.TabIndex = 19;
            // 
            // Actor_Rating_TimePicker
            // 
            Actor_Rating_TimePicker.CustomFormat = "MM/yyyy";
            Actor_Rating_TimePicker.Format = DateTimePickerFormat.Custom;
            Actor_Rating_TimePicker.Location = new Point(493, 151);
            Actor_Rating_TimePicker.Name = "Actor_Rating_TimePicker";
            Actor_Rating_TimePicker.ShowUpDown = true;
            Actor_Rating_TimePicker.Size = new Size(250, 27);
            Actor_Rating_TimePicker.TabIndex = 19;
            // 
            // Sort_Movie_TimePicker
            // 
            Sort_Movie_TimePicker.CustomFormat = "MM/yyyy";
            Sort_Movie_TimePicker.Format = DateTimePickerFormat.Custom;
            Sort_Movie_TimePicker.Location = new Point(85, 299);
            Sort_Movie_TimePicker.Name = "Sort_Movie_TimePicker";
            Sort_Movie_TimePicker.ShowUpDown = true;
            Sort_Movie_TimePicker.Size = new Size(250, 27);
            Sort_Movie_TimePicker.TabIndex = 18;
            // 
            // Sale_Report_Year_Picker
            // 
            Sale_Report_Year_Picker.CustomFormat = "yyyy";
            Sale_Report_Year_Picker.Format = DateTimePickerFormat.Custom;
            Sale_Report_Year_Picker.Location = new Point(85, 165);
            Sale_Report_Year_Picker.Name = "Sale_Report_Year_Picker";
            Sale_Report_Year_Picker.ShowUpDown = true;
            Sale_Report_Year_Picker.Size = new Size(250, 27);
            Sale_Report_Year_Picker.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(412, 286);
            label6.Name = "label6";
            label6.Size = new Size(75, 23);
            label6.TabIndex = 15;
            label6.Text = "Report 5";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(412, 221);
            label7.Name = "label7";
            label7.Size = new Size(75, 23);
            label7.TabIndex = 14;
            label7.Text = "Report 4";
            label7.Click += label7_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(412, 133);
            label4.Name = "label4";
            label4.Size = new Size(75, 23);
            label4.TabIndex = 13;
            label4.Text = "Report 3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(6, 262);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 12;
            label3.Text = "Report 2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(4, 147);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 11;
            label2.Text = "Report 1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F);
            label1.Location = new Point(303, 15);
            label1.Name = "label1";
            label1.Size = new Size(197, 67);
            label1.TabIndex = 10;
            label1.Text = "Reports";
            // 
            // Movie_Report_ComboBox
            // 
            Movie_Report_ComboBox.Font = new Font("Segoe UI", 10F);
            Movie_Report_ComboBox.FormattingEnabled = true;
            Movie_Report_ComboBox.ItemHeight = 23;
            Movie_Report_ComboBox.Items.AddRange(new object[] { "Comedy", "Drama", "Action", "Foreign" });
            Movie_Report_ComboBox.Location = new Point(85, 272);
            Movie_Report_ComboBox.Name = "Movie_Report_ComboBox";
            Movie_Report_ComboBox.Size = new Size(250, 31);
            Movie_Report_ComboBox.TabIndex = 9;
            Movie_Report_ComboBox.SelectedIndexChanged += Movie_Report_ComboBox_SelectedIndexChanged;
            // 
            // Recommend_Movie_Button
            // 
            Recommend_Movie_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Recommend_Movie_Button.Location = new Point(493, 272);
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
            Most_Frequent_Customers_Button.Location = new Point(493, 194);
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
            Actor_Rating_Button.Location = new Point(493, 106);
            Actor_Rating_Button.Name = "Actor_Rating_Button";
            Actor_Rating_Button.Size = new Size(250, 50);
            Actor_Rating_Button.TabIndex = 2;
            Actor_Rating_Button.Text = "Actor Rating";
            Actor_Rating_Button.UseVisualStyleBackColor = true;
            Actor_Rating_Button.Click += Actor_Rating_Button_Click;
            // 
            // Type_Movies_Button
            // 
            Type_Movies_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Type_Movies_Button.Location = new Point(85, 226);
            Type_Movies_Button.Name = "Type_Movies_Button";
            Type_Movies_Button.Size = new Size(250, 50);
            Type_Movies_Button.TabIndex = 1;
            Type_Movies_Button.Text = "Movie Type: ";
            Type_Movies_Button.UseVisualStyleBackColor = true;
            Type_Movies_Button.Click += Sort_Movies_Button_Click;
            // 
            // Monthly_Sales_Report_Button
            // 
            Monthly_Sales_Report_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Monthly_Sales_Report_Button.Location = new Point(85, 120);
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
        private Button Type_Movies_Button;
        private Button Monthly_Sales_Report_Button;
        private Button Recommend_Movie_Button;
        private Button Most_Frequent_Customers_Button;
        private DataGridView Data;
        private Button Home_Button;
        private ComboBox Movie_Report_ComboBox;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker Sale_Report_Year_Picker;
        private Label label6;
        private DateTimePicker Frequent_Customer_TimePicker;
        private DateTimePicker Actor_Rating_TimePicker;
        private DateTimePicker Sort_Movie_TimePicker;
    }
}