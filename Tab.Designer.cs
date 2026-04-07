namespace test2
{
    partial class Tab
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
            Edit = new TabPage();
            EB_change = new Button();
            E_cancel = new Button();
            E_type = new ComboBox();
            E_cost = new TextBox();
            E_rent = new TextBox();
            E_copy = new TextBox();
            E_search = new TextBox();
            cost = new Label();
            E_actor = new Label();
            label = new Label();
            label10 = new Label();
            label9 = new Label();
            Add = new TabPage();
            A_rent = new TextBox();
            A_copy = new TextBox();
            A_cost = new TextBox();
            A_search = new TextBox();
            label11 = new Label();
            AB_clear = new Button();
            AB_add = new Button();
            A_type = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Search = new TabPage();
            MB_assign = new Button();
            MB_edit = new Button();
            MB_delete = new Button();
            S_mini_cost = new NumericUpDown();
            S_max_cost = new NumericUpDown();
            S_mini_rent = new NumericUpDown();
            S_mini_copy = new NumericUpDown();
            S_max_rent = new NumericUpDown();
            S_max_copy = new NumericUpDown();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            M_search = new TextBox();
            M_data = new DataGridView();
            MB_search = new Button();
            M_type = new ComboBox();
            Lable2 = new Label();
            lable1 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            AA_remove = new Button();
            AA_add = new Button();
            list_assign = new ListBox();
            list_ava = new ListBox();
            label12 = new Label();
            label8 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            Edit.SuspendLayout();
            Add.SuspendLayout();
            Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)S_mini_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_max_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_rent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_copy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_max_rent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_max_copy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M_data).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // Edit
            // 
            Edit.Controls.Add(EB_change);
            Edit.Controls.Add(E_cancel);
            Edit.Controls.Add(E_type);
            Edit.Controls.Add(E_cost);
            Edit.Controls.Add(E_rent);
            Edit.Controls.Add(E_copy);
            Edit.Controls.Add(E_search);
            Edit.Controls.Add(cost);
            Edit.Controls.Add(E_actor);
            Edit.Controls.Add(label);
            Edit.Controls.Add(label10);
            Edit.Controls.Add(label9);
            Edit.Location = new Point(4, 34);
            Edit.Name = "Edit";
            Edit.Padding = new Padding(3);
            Edit.Size = new Size(1063, 513);
            Edit.TabIndex = 3;
            Edit.Text = "Edit";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += Edit_Click;
            // 
            // EB_change
            // 
            EB_change.Location = new Point(48, 326);
            EB_change.Name = "EB_change";
            EB_change.Size = new Size(322, 66);
            EB_change.TabIndex = 14;
            EB_change.Text = "Change";
            EB_change.UseVisualStyleBackColor = true;
            EB_change.Click += EB_change_Click;
            // 
            // E_cancel
            // 
            E_cancel.Location = new Point(485, 326);
            E_cancel.Name = "E_cancel";
            E_cancel.Size = new Size(322, 66);
            E_cancel.TabIndex = 11;
            E_cancel.Text = "Cancel";
            E_cancel.UseVisualStyleBackColor = true;
            E_cancel.Click += E_cancel_Click;
            // 
            // E_type
            // 
            E_type.FormattingEnabled = true;
            E_type.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            E_type.Location = new Point(176, 66);
            E_type.Name = "E_type";
            E_type.Size = new Size(174, 33);
            E_type.TabIndex = 9;
            E_type.SelectedIndexChanged += E_type_SelectedIndexChanged;
            // 
            // E_cost
            // 
            E_cost.Location = new Point(188, 191);
            E_cost.Name = "E_cost";
            E_cost.Size = new Size(162, 31);
            E_cost.TabIndex = 8;
            E_cost.TextChanged += E_cost_TextChanged;
            // 
            // E_rent
            // 
            E_rent.Location = new Point(188, 144);
            E_rent.Name = "E_rent";
            E_rent.Size = new Size(162, 31);
            E_rent.TabIndex = 7;
            E_rent.TextChanged += E_rent_TextChanged;
            // 
            // E_copy
            // 
            E_copy.Location = new Point(188, 105);
            E_copy.Name = "E_copy";
            E_copy.Size = new Size(162, 31);
            E_copy.TabIndex = 6;
            E_copy.TextChanged += E_copy_TextChanged;
            // 
            // E_search
            // 
            E_search.Location = new Point(146, 24);
            E_search.Name = "E_search";
            E_search.Size = new Size(471, 31);
            E_search.TabIndex = 5;
            E_search.TextChanged += E_search_TextChanged;
            // 
            // cost
            // 
            cost.AutoSize = true;
            cost.Location = new Point(27, 191);
            cost.Name = "cost";
            cost.Size = new Size(48, 25);
            cost.TabIndex = 4;
            cost.Text = "Cost";
            // 
            // E_actor
            // 
            E_actor.AutoSize = true;
            E_actor.Location = new Point(27, 147);
            E_actor.Name = "E_actor";
            E_actor.Size = new Size(133, 25);
            E_actor.TabIndex = 3;
            E_actor.Text = "Number rented";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(27, 105);
            label.Name = "label";
            label.Size = new Size(155, 25);
            label.TabIndex = 2;
            label.Text = "Number of copies";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(27, 63);
            label10.Name = "label10";
            label10.Size = new Size(49, 25);
            label10.TabIndex = 1;
            label10.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 24);
            label9.Name = "label9";
            label9.Size = new Size(113, 25);
            label9.TabIndex = 0;
            label9.Text = "Movie Name";
            // 
            // Add
            // 
            Add.Controls.Add(A_rent);
            Add.Controls.Add(A_copy);
            Add.Controls.Add(A_cost);
            Add.Controls.Add(A_search);
            Add.Controls.Add(label11);
            Add.Controls.Add(AB_clear);
            Add.Controls.Add(AB_add);
            Add.Controls.Add(A_type);
            Add.Controls.Add(label6);
            Add.Controls.Add(label5);
            Add.Controls.Add(label4);
            Add.Controls.Add(label3);
            Add.Location = new Point(4, 34);
            Add.Name = "Add";
            Add.Padding = new Padding(3);
            Add.Size = new Size(1063, 513);
            Add.TabIndex = 1;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            // 
            // A_rent
            // 
            A_rent.Location = new Point(196, 220);
            A_rent.Name = "A_rent";
            A_rent.Size = new Size(192, 31);
            A_rent.TabIndex = 13;
            A_rent.TextChanged += A_rent_TextChanged;
            // 
            // A_copy
            // 
            A_copy.Location = new Point(196, 154);
            A_copy.Name = "A_copy";
            A_copy.Size = new Size(192, 31);
            A_copy.TabIndex = 12;
            A_copy.TextChanged += A_copy_TextChanged;
            // 
            // A_cost
            // 
            A_cost.Location = new Point(196, 281);
            A_cost.Name = "A_cost";
            A_cost.Size = new Size(192, 31);
            A_cost.TabIndex = 11;
            A_cost.TextChanged += A_cost_TextChanged;
            // 
            // A_search
            // 
            A_search.Location = new Point(154, 31);
            A_search.Name = "A_search";
            A_search.Size = new Size(520, 31);
            A_search.TabIndex = 4;
            A_search.TextChanged += A_search_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 281);
            label11.Name = "label11";
            label11.Size = new Size(48, 25);
            label11.TabIndex = 10;
            label11.Text = "Cost";
            // 
            // AB_clear
            // 
            AB_clear.Location = new Point(63, 376);
            AB_clear.Name = "AB_clear";
            AB_clear.Size = new Size(360, 76);
            AB_clear.TabIndex = 9;
            AB_clear.Text = "Clear";
            AB_clear.UseVisualStyleBackColor = true;
            AB_clear.Click += AB_clear_Click;
            // 
            // AB_add
            // 
            AB_add.Location = new Point(576, 376);
            AB_add.Name = "AB_add";
            AB_add.Size = new Size(360, 76);
            AB_add.TabIndex = 9;
            AB_add.Text = "Add";
            AB_add.UseVisualStyleBackColor = true;
            AB_add.Click += AB_add_Click;
            // 
            // A_type
            // 
            A_type.FormattingEnabled = true;
            A_type.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            A_type.Location = new Point(196, 91);
            A_type.Name = "A_type";
            A_type.Size = new Size(190, 33);
            A_type.TabIndex = 7;
            A_type.SelectedIndexChanged += A_type_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 220);
            label6.Name = "label6";
            label6.Size = new Size(133, 25);
            label6.TabIndex = 3;
            label6.Text = "Number rented";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 154);
            label5.Name = "label5";
            label5.Size = new Size(155, 25);
            label5.TabIndex = 2;
            label5.Text = "Number of copies";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 91);
            label4.Name = "label4";
            label4.Size = new Size(49, 25);
            label4.TabIndex = 1;
            label4.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 34);
            label3.Name = "label3";
            label3.Size = new Size(113, 25);
            label3.TabIndex = 0;
            label3.Text = "Movie Name";
            // 
            // Search
            // 
            Search.Controls.Add(MB_assign);
            Search.Controls.Add(MB_edit);
            Search.Controls.Add(MB_delete);
            Search.Controls.Add(S_mini_cost);
            Search.Controls.Add(S_max_cost);
            Search.Controls.Add(S_mini_rent);
            Search.Controls.Add(S_mini_copy);
            Search.Controls.Add(S_max_rent);
            Search.Controls.Add(S_max_copy);
            Search.Controls.Add(label7);
            Search.Controls.Add(label2);
            Search.Controls.Add(label1);
            Search.Controls.Add(M_search);
            Search.Controls.Add(M_data);
            Search.Controls.Add(MB_search);
            Search.Controls.Add(M_type);
            Search.Controls.Add(Lable2);
            Search.Controls.Add(lable1);
            Search.Location = new Point(4, 34);
            Search.Name = "Search";
            Search.Padding = new Padding(3);
            Search.Size = new Size(1063, 513);
            Search.TabIndex = 0;
            Search.Text = "Main";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // MB_assign
            // 
            MB_assign.Location = new Point(856, 135);
            MB_assign.Name = "MB_assign";
            MB_assign.Size = new Size(173, 62);
            MB_assign.TabIndex = 20;
            MB_assign.Text = "Assgin Actor";
            MB_assign.UseVisualStyleBackColor = true;
            MB_assign.Click += MB_assign_Click;
            // 
            // MB_edit
            // 
            MB_edit.Location = new Point(677, 135);
            MB_edit.Name = "MB_edit";
            MB_edit.Size = new Size(173, 62);
            MB_edit.TabIndex = 19;
            MB_edit.Text = "Edit";
            MB_edit.UseVisualStyleBackColor = true;
            MB_edit.Click += MB_edit_Click_Click;
            // 
            // MB_delete
            // 
            MB_delete.Location = new Point(498, 135);
            MB_delete.Name = "MB_delete";
            MB_delete.Size = new Size(173, 62);
            MB_delete.TabIndex = 19;
            MB_delete.Text = "Delete";
            MB_delete.UseVisualStyleBackColor = true;
            MB_delete.Click += MB_delete_Click_Click;
            // 
            // S_mini_cost
            // 
            S_mini_cost.Location = new Point(234, 129);
            S_mini_cost.Name = "S_mini_cost";
            S_mini_cost.Size = new Size(65, 31);
            S_mini_cost.TabIndex = 18;
            S_mini_cost.ValueChanged += S_mini_cost_ValueChanged;
            // 
            // S_max_cost
            // 
            S_max_cost.Location = new Point(154, 129);
            S_max_cost.Name = "S_max_cost";
            S_max_cost.Size = new Size(65, 31);
            S_max_cost.TabIndex = 17;
            S_max_cost.Value = new decimal(new int[] { 100, 0, 0, 0 });
            S_max_cost.ValueChanged += S_max_cost_ValueChanged;
            // 
            // S_mini_rent
            // 
            S_mini_rent.Location = new Point(804, 77);
            S_mini_rent.Name = "S_mini_rent";
            S_mini_rent.Size = new Size(78, 31);
            S_mini_rent.TabIndex = 16;
            S_mini_rent.ValueChanged += S_mini_rent_ValueChanged;
            // 
            // S_mini_copy
            // 
            S_mini_copy.Location = new Point(804, 31);
            S_mini_copy.Name = "S_mini_copy";
            S_mini_copy.Size = new Size(78, 31);
            S_mini_copy.TabIndex = 15;
            S_mini_copy.ValueChanged += S_mini_copy_ValueChanged;
            // 
            // S_max_rent
            // 
            S_max_rent.Location = new Point(720, 77);
            S_max_rent.Name = "S_max_rent";
            S_max_rent.Size = new Size(78, 31);
            S_max_rent.TabIndex = 14;
            S_max_rent.Value = new decimal(new int[] { 100, 0, 0, 0 });
            S_max_rent.ValueChanged += S_max_rent_ValueChanged;
            // 
            // S_max_copy
            // 
            S_max_copy.Location = new Point(720, 33);
            S_max_copy.Name = "S_max_copy";
            S_max_copy.Size = new Size(78, 31);
            S_max_copy.TabIndex = 13;
            S_max_copy.Value = new decimal(new int[] { 100, 0, 0, 0 });
            S_max_copy.ValueChanged += S_max_copy_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 135);
            label7.Name = "label7";
            label7.Size = new Size(48, 25);
            label7.TabIndex = 12;
            label7.Text = "Cost";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 79);
            label2.Name = "label2";
            label2.Size = new Size(133, 25);
            label2.TabIndex = 11;
            label2.Text = "Number rented";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(538, 33);
            label1.Name = "label1";
            label1.Size = new Size(155, 25);
            label1.TabIndex = 10;
            label1.Text = "Number of copies";
            // 
            // M_search
            // 
            M_search.Location = new Point(154, 24);
            M_search.Name = "M_search";
            M_search.Size = new Size(363, 31);
            M_search.TabIndex = 9;
            M_search.TextChanged += M_search_TextChanged;
            // 
            // M_data
            // 
            M_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            M_data.Location = new Point(35, 203);
            M_data.Name = "M_data";
            M_data.RowHeadersWidth = 62;
            M_data.Size = new Size(1017, 299);
            M_data.TabIndex = 7;
            M_data.CellContentClick += M_data_CellContentClick;
            // 
            // MB_search
            // 
            MB_search.Location = new Point(318, 135);
            MB_search.Name = "MB_search";
            MB_search.Size = new Size(173, 62);
            MB_search.TabIndex = 5;
            MB_search.Text = "Search";
            MB_search.UseVisualStyleBackColor = true;
            MB_search.Click += MB_search_Click;
            // 
            // M_type
            // 
            M_type.FormattingEnabled = true;
            M_type.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            M_type.Location = new Point(154, 73);
            M_type.Name = "M_type";
            M_type.Size = new Size(249, 33);
            M_type.TabIndex = 4;
            M_type.SelectedIndexChanged += M_type_SelectedIndexChanged;
            // 
            // Lable2
            // 
            Lable2.AutoSize = true;
            Lable2.Location = new Point(35, 81);
            Lable2.Name = "Lable2";
            Lable2.Size = new Size(49, 25);
            Lable2.TabIndex = 1;
            Lable2.Text = "Type";
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(35, 24);
            lable1.Name = "lable1";
            lable1.Size = new Size(113, 25);
            lable1.TabIndex = 0;
            lable1.Text = "Moive Name";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Search);
            tabControl1.Controls.Add(Add);
            tabControl1.Controls.Add(Edit);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 551);
            tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(AA_remove);
            tabPage2.Controls.Add(AA_add);
            tabPage2.Controls.Add(list_assign);
            tabPage2.Controls.Add(list_ava);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label8);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1063, 513);
            tabPage2.TabIndex = 4;
            tabPage2.Text = "Actor";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AA_remove
            // 
            AA_remove.Location = new Point(593, 300);
            AA_remove.Name = "AA_remove";
            AA_remove.Size = new Size(171, 64);
            AA_remove.TabIndex = 6;
            AA_remove.Text = "Remove";
            AA_remove.UseVisualStyleBackColor = true;
            AA_remove.Click += AA_remove_Click;
            // 
            // AA_add
            // 
            AA_add.Location = new Point(315, 300);
            AA_add.Name = "AA_add";
            AA_add.Size = new Size(171, 64);
            AA_add.TabIndex = 6;
            AA_add.Text = "Add";
            AA_add.UseVisualStyleBackColor = true;
            AA_add.Click += AA_add_Click;
            // 
            // list_assign
            // 
            list_assign.FormattingEnabled = true;
            list_assign.Location = new Point(693, 44);
            list_assign.Name = "list_assign";
            list_assign.Size = new Size(364, 179);
            list_assign.TabIndex = 5;
            list_assign.SelectedIndexChanged += list_assign_SelectedIndexChanged;
            // 
            // list_ava
            // 
            list_ava.FormattingEnabled = true;
            list_ava.Location = new Point(5, 44);
            list_ava.Name = "list_ava";
            list_ava.Size = new Size(364, 179);
            list_ava.TabIndex = 4;
            list_ava.SelectedIndexChanged += list_ava_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(5, 16);
            label12.Name = "label12";
            label12.Size = new Size(136, 25);
            label12.TabIndex = 3;
            label12.Text = "Available actors";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(693, 16);
            label8.Name = "label8";
            label8.Size = new Size(138, 25);
            label8.TabIndex = 2;
            label8.Text = "Assigned actors";
            label8.Click += label8_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 550);
            Controls.Add(tabControl1);
            Name = "Tab";
            Text = "Tab";
            Edit.ResumeLayout(false);
            Edit.PerformLayout();
            Add.ResumeLayout(false);
            Add.PerformLayout();
            Search.ResumeLayout(false);
            Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)S_mini_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_max_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_rent).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_copy).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_max_rent).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_max_copy).EndInit();
            ((System.ComponentModel.ISupportInitialize)M_data).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabPage Edit;
        private Button EB_change;
        private Button E_cancel;
        private ComboBox E_type;
        private TextBox E_cost;
        private TextBox E_rent;
        private TextBox E_copy;
        private TextBox E_search;
        private Label cost;
        private Label E_actor;
        private Label label;
        private Label label10;
        private Label label9;
        private TabPage Add;
        private TextBox A_rent;
        private TextBox A_copy;
        private TextBox A_cost;
        private TextBox A_search;
        private Label label11;
        private Button AB_clear;
        private Button AB_add;
        private ComboBox A_type;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TabPage Search;
        private Button MB_edit;
        private Button MB_delete;
        private NumericUpDown S_mini_cost;
        private NumericUpDown S_max_cost;
        private NumericUpDown S_mini_rent;
        private NumericUpDown S_mini_copy;
        private NumericUpDown S_max_rent;
        private NumericUpDown S_max_copy;
        private Label label7;
        private Label label2;
        private Label label1;
        private TextBox M_search;
        private DataGridView M_data;
        private Button MB_search;
        private ComboBox M_type;
        private Label Lable2;
        private Label lable1;
        private TabControl tabControl1;
        private ContextMenuStrip contextMenuStrip1;
        private Button MB_assign;
        private TabPage tabPage2;
        private Label label12;
        private Label label8;
        private Button AA_remove;
        private Button AA_add;
        private ListBox list_assign;
        private ListBox list_ava;
    }
}