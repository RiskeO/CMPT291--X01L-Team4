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
            Option5_Button = new Button();
            Option4_Button = new Button();
            Option3_Button = new Button();
            Option2_Button = new Button();
            Option1_Button = new Button();
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
            Options_Tab.Controls.Add(Option5_Button);
            Options_Tab.Controls.Add(Option4_Button);
            Options_Tab.Controls.Add(Option3_Button);
            Options_Tab.Controls.Add(Option2_Button);
            Options_Tab.Controls.Add(Option1_Button);
            Options_Tab.Location = new Point(4, 29);
            Options_Tab.Name = "Options_Tab";
            Options_Tab.Padding = new Padding(3);
            Options_Tab.Size = new Size(780, 424);
            Options_Tab.TabIndex = 0;
            Options_Tab.Text = "Options";
            Options_Tab.UseVisualStyleBackColor = true;
            // 
            // Option5_Button
            // 
            Option5_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option5_Button.Location = new Point(275, 330);
            Option5_Button.Name = "Option5_Button";
            Option5_Button.Size = new Size(250, 50);
            Option5_Button.TabIndex = 4;
            Option5_Button.Text = "Option5";
            Option5_Button.UseVisualStyleBackColor = true;
            Option5_Button.Click += Option5_Button_Click;
            // 
            // Option4_Button
            // 
            Option4_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option4_Button.Location = new Point(275, 261);
            Option4_Button.Name = "Option4_Button";
            Option4_Button.Size = new Size(250, 50);
            Option4_Button.TabIndex = 3;
            Option4_Button.Text = "Option4";
            Option4_Button.UseVisualStyleBackColor = true;
            Option4_Button.Click += Option4_Button_Click;
            // 
            // Option3_Button
            // 
            Option3_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option3_Button.Location = new Point(275, 193);
            Option3_Button.Name = "Option3_Button";
            Option3_Button.Size = new Size(250, 50);
            Option3_Button.TabIndex = 2;
            Option3_Button.Text = "Option3";
            Option3_Button.UseVisualStyleBackColor = true;
            Option3_Button.Click += Option3_Button_Click;
            // 
            // Option2_Button
            // 
            Option2_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option2_Button.Location = new Point(275, 125);
            Option2_Button.Name = "Option2_Button";
            Option2_Button.Size = new Size(250, 50);
            Option2_Button.TabIndex = 1;
            Option2_Button.Text = "Option2";
            Option2_Button.UseVisualStyleBackColor = true;
            Option2_Button.Click += Option2_Button_Click;
            // 
            // Option1_Button
            // 
            Option1_Button.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Option1_Button.Location = new Point(275, 56);
            Option1_Button.Name = "Option1_Button";
            Option1_Button.Size = new Size(250, 50);
            Option1_Button.TabIndex = 0;
            Option1_Button.Text = "Option1";
            Option1_Button.UseVisualStyleBackColor = true;
            Option1_Button.Click += Option1_Button_Click;
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
            Data_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private TabControl Report_TabControl;
        private TabPage Options_Tab;
        private TabPage Data_Tab;
        private Button Option3_Button;
        private Button Option2_Button;
        private Button Option1_Button;
        private Button Option5_Button;
        private Button Option4_Button;
        private DataGridView Data;
        private Button Home_Button;
    }
}