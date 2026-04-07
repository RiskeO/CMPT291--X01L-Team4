namespace Movie_Rental_System
{
    partial class Rental
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
            QueueData = new DataGridView();
            RefreshQueueButton = new Button();
            RentMovieButton = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)QueueData).BeginInit();
            SuspendLayout();
            // 
            // Home_Button
            // 
            Home_Button.BackColor = Color.Green;
            Home_Button.ForeColor = SystemColors.ControlLightLight;
            Home_Button.Location = new Point(1106, 2);
            Home_Button.Margin = new Padding(5);
            Home_Button.Name = "Home_Button";
            Home_Button.Size = new Size(162, 45);
            Home_Button.TabIndex = 3;
            Home_Button.Text = "Home";
            Home_Button.UseVisualStyleBackColor = false;
            Home_Button.Click += Home_Button_Click;
            // 
            // QueueData
            // 
            QueueData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            QueueData.Location = new Point(12, 68);
            QueueData.Name = "QueueData";
            QueueData.ReadOnly = true;
            QueueData.RowHeadersWidth = 82;
            QueueData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            QueueData.Size = new Size(1247, 645);
            QueueData.TabIndex = 4;
            QueueData.CellContentClick += dataGridView1_CellContentClick;
            // 
            // RefreshQueueButton
            // 
            RefreshQueueButton.Location = new Point(12, 12);
            RefreshQueueButton.Name = "RefreshQueueButton";
            RefreshQueueButton.Size = new Size(257, 46);
            RefreshQueueButton.TabIndex = 6;
            RefreshQueueButton.Text = "Show/Refresh Queue";
            RefreshQueueButton.UseVisualStyleBackColor = true;
            RefreshQueueButton.Click += refresh_Queue;
            // 
            // RentMovieButton
            // 
            RentMovieButton.Location = new Point(275, 12);
            RentMovieButton.Name = "RentMovieButton";
            RentMovieButton.Size = new Size(273, 46);
            RentMovieButton.TabIndex = 7;
            RentMovieButton.Text = "Rent Movie";
            RentMovieButton.UseVisualStyleBackColor = true;
            RentMovieButton.Click += RentMovieButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(626, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 39);
            textBox1.TabIndex = 8;
            // 
            // Rental
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1271, 725);
            Controls.Add(textBox1);
            Controls.Add(RentMovieButton);
            Controls.Add(RefreshQueueButton);
            Controls.Add(QueueData);
            Controls.Add(Home_Button);
            Name = "Rental";
            Text = "Rental";
            Load += Rental_Load;
            ((System.ComponentModel.ISupportInitialize)QueueData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Home_Button;
        private DataGridView QueueData;
        private Button RefreshQueueButton;
        private Button RentMovieButton;
        private TextBox textBox1;
    }
}