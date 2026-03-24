namespace Movie_Rental_System
{
    partial class MainMenu
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
            Customer_Button = new Button();
            label2 = new Label();
            Movie_Button = new Button();
            Rental_Button = new Button();
            Report_Button = new Button();
            Logout_Button = new Button();
            SuspendLayout();
            // 
            // Customer_Button
            // 
            Customer_Button.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Customer_Button.Location = new Point(250, 105);
            Customer_Button.Name = "Customer_Button";
            Customer_Button.Size = new Size(300, 60);
            Customer_Button.TabIndex = 0;
            Customer_Button.Text = "Customer";
            Customer_Button.UseVisualStyleBackColor = true;
            Customer_Button.Click += Customer_Button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(282, 48);
            label2.Name = "label2";
            label2.Size = new Size(237, 54);
            label2.TabIndex = 2;
            label2.Text = "Main Menu";
            // 
            // Movie_Button
            // 
            Movie_Button.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Movie_Button.Location = new Point(250, 173);
            Movie_Button.Name = "Movie_Button";
            Movie_Button.Size = new Size(300, 60);
            Movie_Button.TabIndex = 3;
            Movie_Button.Text = "Movie";
            Movie_Button.UseVisualStyleBackColor = true;
            Movie_Button.Click += Movie_Button_Click;
            // 
            // Rental_Button
            // 
            Rental_Button.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rental_Button.Location = new Point(250, 239);
            Rental_Button.Name = "Rental_Button";
            Rental_Button.Size = new Size(300, 60);
            Rental_Button.TabIndex = 4;
            Rental_Button.Text = "Rental";
            Rental_Button.UseVisualStyleBackColor = true;
            Rental_Button.Click += Rental_Button_Click;
            // 
            // Report_Button
            // 
            Report_Button.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Report_Button.Location = new Point(250, 305);
            Report_Button.Name = "Report_Button";
            Report_Button.Size = new Size(300, 60);
            Report_Button.TabIndex = 5;
            Report_Button.Text = "Report";
            Report_Button.UseVisualStyleBackColor = true;
            Report_Button.Click += Report_Button_Click;
            // 
            // Logout_Button
            // 
            Logout_Button.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Logout_Button.Location = new Point(250, 371);
            Logout_Button.Name = "Logout_Button";
            Logout_Button.Size = new Size(300, 60);
            Logout_Button.TabIndex = 6;
            Logout_Button.Text = "Logout";
            Logout_Button.UseVisualStyleBackColor = true;
            Logout_Button.Click += Logout_Button_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Logout_Button);
            Controls.Add(Report_Button);
            Controls.Add(Rental_Button);
            Controls.Add(Movie_Button);
            Controls.Add(label2);
            Controls.Add(Customer_Button);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Customer_Button;
        private Label label1;
        private Label label2;
        private Button Movie_Button;
        private Button Rental_Button;
        private Button Report_Button;
        private Button Logout_Button;
    }
}