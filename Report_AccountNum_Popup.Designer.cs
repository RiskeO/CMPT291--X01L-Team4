namespace Movie_Rental_System
{
    partial class Report_Select_Customer_ID
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
            FamilyName = new Label();
            FirstName = new Label();
            Recommend_LastName_TextBox = new TextBox();
            Recommend_FirstName_TextBox = new TextBox();
            Find_button = new Button();
            Customer_GridView = new DataGridView();
            Done_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)Customer_GridView).BeginInit();
            SuspendLayout();
            // 
            // FamilyName
            // 
            FamilyName.AutoSize = true;
            FamilyName.Location = new Point(397, 9);
            FamilyName.Name = "FamilyName";
            FamilyName.Size = new Size(95, 20);
            FamilyName.TabIndex = 12;
            FamilyName.Text = "Family Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(139, 9);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(80, 20);
            FirstName.TabIndex = 11;
            FirstName.Text = "First Name";
            // 
            // Recommend_LastName_TextBox
            // 
            Recommend_LastName_TextBox.Location = new Point(329, 35);
            Recommend_LastName_TextBox.Name = "Recommend_LastName_TextBox";
            Recommend_LastName_TextBox.Size = new Size(228, 27);
            Recommend_LastName_TextBox.TabIndex = 10;
            Recommend_LastName_TextBox.TextChanged += Recommend_LastName_TextBox_TextChanged;
            // 
            // Recommend_FirstName_TextBox
            // 
            Recommend_FirstName_TextBox.Location = new Point(75, 35);
            Recommend_FirstName_TextBox.Name = "Recommend_FirstName_TextBox";
            Recommend_FirstName_TextBox.Size = new Size(228, 27);
            Recommend_FirstName_TextBox.TabIndex = 9;
            // 
            // Find_button
            // 
            Find_button.Location = new Point(579, 33);
            Find_button.Name = "Find_button";
            Find_button.Size = new Size(94, 29);
            Find_button.TabIndex = 13;
            Find_button.Text = "Find";
            Find_button.UseVisualStyleBackColor = true;
            Find_button.Click += Submit_button_Click;
            // 
            // Customer_GridView
            // 
            Customer_GridView.AllowUserToAddRows = false;
            Customer_GridView.AllowUserToDeleteRows = false;
            Customer_GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Customer_GridView.Location = new Point(12, 79);
            Customer_GridView.MultiSelect = false;
            Customer_GridView.Name = "Customer_GridView";
            Customer_GridView.ReadOnly = true;
            Customer_GridView.RowHeadersWidth = 51;
            Customer_GridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Customer_GridView.Size = new Size(776, 359);
            Customer_GridView.TabIndex = 14;
            // 
            // Done_Button
            // 
            Done_Button.BackColor = Color.FromArgb(0, 192, 0);
            Done_Button.Location = new Point(694, 33);
            Done_Button.Name = "Done_Button";
            Done_Button.Size = new Size(94, 29);
            Done_Button.TabIndex = 15;
            Done_Button.Text = "Done";
            Done_Button.UseVisualStyleBackColor = false;
            Done_Button.Click += Done_Button_Click;
            // 
            // Report_Select_Customer_ID
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Done_Button);
            Controls.Add(Customer_GridView);
            Controls.Add(Find_button);
            Controls.Add(FamilyName);
            Controls.Add(FirstName);
            Controls.Add(Recommend_LastName_TextBox);
            Controls.Add(Recommend_FirstName_TextBox);
            KeyPreview = true;
            Name = "Report_Select_Customer_ID";
            Text = "Report_Select_Customer_ID";
            KeyDown += Report_Select_Customer_ID_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Customer_GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FamilyName;
        private Label FirstName;
        private TextBox Recommend_LastName_TextBox;
        private TextBox Recommend_FirstName_TextBox;
        private Button Find_button;
        private DataGridView Customer_GridView;
        private Button Done_Button;
    }
}