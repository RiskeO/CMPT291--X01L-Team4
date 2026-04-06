namespace Movie_Rental_System
{
    partial class Login
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
            Email_textbox = new TextBox();
            Password_textbox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Login_Text = new Label();
            Login_Button = new Button();
            email_text = new Label();
            Password_text = new Label();
            SuspendLayout();
            // 
            // Email_textbox
            // 
            Email_textbox.Location = new Point(200, 161);
            Email_textbox.Name = "Email_textbox";
            Email_textbox.Size = new Size(400, 27);
            Email_textbox.TabIndex = 0;
            // 
            // Password_textbox
            // 
            Password_textbox.Location = new Point(200, 225);
            Password_textbox.Name = "Password_textbox";
            Password_textbox.PasswordChar = '*';
            Password_textbox.Size = new Size(401, 27);
            Password_textbox.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Login_Text
            // 
            Login_Text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Login_Text.AutoSize = true;
            Login_Text.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Text.Location = new Point(333, 75);
            Login_Text.Name = "Login_Text";
            Login_Text.Size = new Size(134, 60);
            Login_Text.TabIndex = 3;
            Login_Text.Text = "Login";
            Login_Text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login_Button
            // 
            Login_Button.Font = new Font("Segoe UI", 12F);
            Login_Button.Location = new Point(325, 300);
            Login_Button.Name = "Login_Button";
            Login_Button.Size = new Size(150, 50);
            Login_Button.TabIndex = 4;
            Login_Button.Text = "Login";
            Login_Button.UseVisualStyleBackColor = true;
            Login_Button.Click += Login_Button_Click_1;
            // 
            // email_text
            // 
            email_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            email_text.AutoSize = true;
            email_text.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_text.Location = new Point(201, 138);
            email_text.Name = "email_text";
            email_text.Size = new Size(46, 20);
            email_text.TabIndex = 5;
            email_text.Text = "Email";
            email_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Password_text
            // 
            Password_text.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Password_text.AutoSize = true;
            Password_text.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Password_text.Location = new Point(200, 205);
            Password_text.Name = "Password_text";
            Password_text.Size = new Size(70, 20);
            Password_text.TabIndex = 6;
            Password_text.Text = "Password";
            Password_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(Password_text);
            Controls.Add(email_text);
            Controls.Add(Login_Button);
            Controls.Add(Login_Text);
            Controls.Add(Password_textbox);
            Controls.Add(Email_textbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            Text = "Login";
            KeyDown += Login_KeyDown_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Email_textbox;
        private TextBox Password_textbox;
        private ContextMenuStrip contextMenuStrip1;
        private Label Login_Text;
        private Button Login_Button;
        private Label email_text;
        private Label Password_text;

    }
}