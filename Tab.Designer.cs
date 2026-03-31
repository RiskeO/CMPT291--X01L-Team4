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
            tabControl1 = new TabControl();
            Search = new TabPage();
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
            Add = new TabPage();
            A_rent = new TextBox();
            A_copy = new TextBox();
            A_cost = new TextBox();
            label11 = new Label();
            AB_clear = new Button();
            AB_add = new Button();
            A_data = new DataGridView();
            A_type = new ComboBox();
            A_search = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Delete = new TabPage();
            D_mini_rent = new NumericUpDown();
            D_mini_cost = new NumericUpDown();
            D_mini_copy = new NumericUpDown();
            D_max_rent = new NumericUpDown();
            D_man_cost = new NumericUpDown();
            D_max_copy = new NumericUpDown();
            label13 = new Label();
            label12 = new Label();
            label8 = new Label();
            D_data = new DataGridView();
            DB_clear = new Button();
            DB_delete = new Button();
            D_type = new ComboBox();
            D_search = new TextBox();
            Lable8 = new Label();
            Lable7 = new Label();
            Edit = new TabPage();
            dataGridView4 = new DataGridView();
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
            EB_change = new Button();
            tabControl1.SuspendLayout();
            Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)S_mini_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_max_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_rent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_copy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_max_rent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)S_max_copy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)M_data).BeginInit();
            Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)A_data).BeginInit();
            Delete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)D_mini_rent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D_mini_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D_mini_copy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D_max_rent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D_man_cost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D_max_copy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)D_data).BeginInit();
            Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Search);
            tabControl1.Controls.Add(Add);
            tabControl1.Controls.Add(Delete);
            tabControl1.Controls.Add(Edit);
            tabControl1.Location = new Point(3, 1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1071, 551);
            tabControl1.TabIndex = 0;
            // 
            // Search
            // 
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
            MB_search.Location = new Point(528, 135);
            MB_search.Name = "MB_search";
            MB_search.Size = new Size(431, 62);
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
            // Add
            // 
            Add.Controls.Add(A_rent);
            Add.Controls.Add(A_copy);
            Add.Controls.Add(A_cost);
            Add.Controls.Add(label11);
            Add.Controls.Add(AB_clear);
            Add.Controls.Add(AB_add);
            Add.Controls.Add(A_data);
            Add.Controls.Add(A_type);
            Add.Controls.Add(A_search);
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
            AB_clear.Location = new Point(52, 423);
            AB_clear.Name = "AB_clear";
            AB_clear.Size = new Size(255, 76);
            AB_clear.TabIndex = 9;
            AB_clear.Text = "Clear";
            AB_clear.UseVisualStyleBackColor = true;
            AB_clear.Click += AB_clear_Click;
            // 
            // AB_add
            // 
            AB_add.Location = new Point(50, 341);
            AB_add.Name = "AB_add";
            AB_add.Size = new Size(255, 76);
            AB_add.TabIndex = 9;
            AB_add.Text = "Add";
            AB_add.UseVisualStyleBackColor = true;
            AB_add.Click += AB_add_Click;
            // 
            // A_data
            // 
            A_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            A_data.Location = new Point(440, 6);
            A_data.Name = "A_data";
            A_data.RowHeadersWidth = 62;
            A_data.Size = new Size(617, 507);
            A_data.TabIndex = 8;
            A_data.CellContentClick += A_data_CellContentClick;
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
            // A_search
            // 
            A_search.Location = new Point(154, 31);
            A_search.Name = "A_search";
            A_search.Size = new Size(278, 31);
            A_search.TabIndex = 4;
            A_search.TextChanged += A_search_TextChanged;
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
            // Delete
            // 
            Delete.Controls.Add(D_mini_rent);
            Delete.Controls.Add(D_mini_cost);
            Delete.Controls.Add(D_mini_copy);
            Delete.Controls.Add(D_max_rent);
            Delete.Controls.Add(D_man_cost);
            Delete.Controls.Add(D_max_copy);
            Delete.Controls.Add(label13);
            Delete.Controls.Add(label12);
            Delete.Controls.Add(label8);
            Delete.Controls.Add(D_data);
            Delete.Controls.Add(DB_clear);
            Delete.Controls.Add(DB_delete);
            Delete.Controls.Add(D_type);
            Delete.Controls.Add(D_search);
            Delete.Controls.Add(Lable8);
            Delete.Controls.Add(Lable7);
            Delete.Location = new Point(4, 34);
            Delete.Name = "Delete";
            Delete.Padding = new Padding(3);
            Delete.Size = new Size(1063, 513);
            Delete.TabIndex = 2;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            // 
            // D_mini_rent
            // 
            D_mini_rent.Location = new Point(292, 192);
            D_mini_rent.Name = "D_mini_rent";
            D_mini_rent.Size = new Size(78, 31);
            D_mini_rent.TabIndex = 17;
            D_mini_rent.ValueChanged += D_mini_rent_ValueChanged;
            // 
            // D_mini_cost
            // 
            D_mini_cost.Location = new Point(292, 242);
            D_mini_cost.Name = "D_mini_cost";
            D_mini_cost.Size = new Size(78, 31);
            D_mini_cost.TabIndex = 17;
            D_mini_cost.ValueChanged += D_mini_cost_ValueChanged;
            // 
            // D_mini_copy
            // 
            D_mini_copy.Location = new Point(292, 140);
            D_mini_copy.Name = "D_mini_copy";
            D_mini_copy.Size = new Size(78, 31);
            D_mini_copy.TabIndex = 17;
            D_mini_copy.ValueChanged += D_mini_copy_ValueChanged;
            // 
            // D_max_rent
            // 
            D_max_rent.Location = new Point(208, 192);
            D_max_rent.Name = "D_max_rent";
            D_max_rent.Size = new Size(78, 31);
            D_max_rent.TabIndex = 16;
            D_max_rent.Value = new decimal(new int[] { 100, 0, 0, 0 });
            D_max_rent.ValueChanged += D_max_rent_ValueChanged;
            // 
            // D_man_cost
            // 
            D_man_cost.Location = new Point(208, 242);
            D_man_cost.Name = "D_man_cost";
            D_man_cost.Size = new Size(78, 31);
            D_man_cost.TabIndex = 16;
            D_man_cost.Value = new decimal(new int[] { 100, 0, 0, 0 });
            D_man_cost.ValueChanged += D_man_cost_ValueChanged;
            // 
            // D_max_copy
            // 
            D_max_copy.Location = new Point(208, 140);
            D_max_copy.Name = "D_max_copy";
            D_max_copy.Size = new Size(78, 31);
            D_max_copy.TabIndex = 16;
            D_max_copy.Value = new decimal(new int[] { 100, 0, 0, 0 });
            D_max_copy.ValueChanged += D_max_copy_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(36, 244);
            label13.Name = "label13";
            label13.Size = new Size(48, 25);
            label13.TabIndex = 8;
            label13.Text = "Cost";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 192);
            label12.Name = "label12";
            label12.Size = new Size(133, 25);
            label12.TabIndex = 7;
            label12.Text = "Number rented";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 140);
            label8.Name = "label8";
            label8.Size = new Size(155, 25);
            label8.TabIndex = 6;
            label8.Text = "Number of copies";
            // 
            // D_data
            // 
            D_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            D_data.Location = new Point(419, 3);
            D_data.Name = "D_data";
            D_data.RowHeadersWidth = 62;
            D_data.Size = new Size(648, 510);
            D_data.TabIndex = 5;
            D_data.CellContentClick += dataGridView3_CellContentClick;
            // 
            // DB_clear
            // 
            DB_clear.Location = new Point(62, 407);
            DB_clear.Name = "DB_clear";
            DB_clear.Size = new Size(264, 60);
            DB_clear.TabIndex = 4;
            DB_clear.Text = "Clear";
            DB_clear.UseVisualStyleBackColor = true;
            DB_clear.Click += DB_clear_Click;
            // 
            // DB_delete
            // 
            DB_delete.Location = new Point(62, 326);
            DB_delete.Name = "DB_delete";
            DB_delete.Size = new Size(264, 60);
            DB_delete.TabIndex = 4;
            DB_delete.Text = "Delete";
            DB_delete.UseVisualStyleBackColor = true;
            DB_delete.Click += DB_delete_Click;
            // 
            // D_type
            // 
            D_type.FormattingEnabled = true;
            D_type.Items.AddRange(new object[] { "Action", "Comedy", "Drama", "Foreign" });
            D_type.Location = new Point(151, 86);
            D_type.Name = "D_type";
            D_type.Size = new Size(255, 33);
            D_type.TabIndex = 3;
            D_type.SelectedIndexChanged += D_type_SelectedIndexChanged;
            // 
            // D_search
            // 
            D_search.Location = new Point(151, 33);
            D_search.Name = "D_search";
            D_search.Size = new Size(257, 31);
            D_search.TabIndex = 2;
            D_search.TextChanged += D_search_TextChanged;
            // 
            // Lable8
            // 
            Lable8.AutoSize = true;
            Lable8.Location = new Point(36, 89);
            Lable8.Name = "Lable8";
            Lable8.Size = new Size(49, 25);
            Lable8.TabIndex = 1;
            Lable8.Text = "Type";
            // 
            // Lable7
            // 
            Lable7.AutoSize = true;
            Lable7.Location = new Point(36, 33);
            Lable7.Name = "Lable7";
            Lable7.Size = new Size(109, 25);
            Lable7.TabIndex = 0;
            Lable7.Text = "Move Name";
            // 
            // Edit
            // 
            Edit.Controls.Add(EB_change);
            Edit.Controls.Add(dataGridView4);
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
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(405, 4);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowHeadersWidth = 62;
            dataGridView4.Size = new Size(657, 506);
            dataGridView4.TabIndex = 13;
            dataGridView4.CellContentClick += dataGridView4_CellContentClick;
            // 
            // E_cancel
            // 
            E_cancel.Location = new Point(66, 387);
            E_cancel.Name = "E_cancel";
            E_cancel.Size = new Size(242, 56);
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
            E_search.Size = new Size(247, 31);
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
            // EB_change
            // 
            EB_change.Location = new Point(66, 311);
            EB_change.Name = "EB_change";
            EB_change.Size = new Size(242, 58);
            EB_change.TabIndex = 14;
            EB_change.Text = "Change";
            EB_change.UseVisualStyleBackColor = true;
            EB_change.Click += EB_change_Click;
            // 
            // Tab
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1076, 550);
            Controls.Add(tabControl1);
            Name = "Tab";
            Text = "Tab";
            tabControl1.ResumeLayout(false);
            Search.ResumeLayout(false);
            Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)S_mini_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_max_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_rent).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_mini_copy).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_max_rent).EndInit();
            ((System.ComponentModel.ISupportInitialize)S_max_copy).EndInit();
            ((System.ComponentModel.ISupportInitialize)M_data).EndInit();
            Add.ResumeLayout(false);
            Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)A_data).EndInit();
            Delete.ResumeLayout(false);
            Delete.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)D_mini_rent).EndInit();
            ((System.ComponentModel.ISupportInitialize)D_mini_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)D_mini_copy).EndInit();
            ((System.ComponentModel.ISupportInitialize)D_max_rent).EndInit();
            ((System.ComponentModel.ISupportInitialize)D_man_cost).EndInit();
            ((System.ComponentModel.ISupportInitialize)D_max_copy).EndInit();
            ((System.ComponentModel.ISupportInitialize)D_data).EndInit();
            Edit.ResumeLayout(false);
            Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Add;
        private TabPage Search;
        private Label Lable2;
        private Label lable1;
        private ComboBox M_type;
        private Button MB_search;
        private DataGridView M_data;
        private TabPage Delete;
        private TabPage Edit;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox A_search;
        private DataGridView A_data;
        private ComboBox A_type;
        private Button AB_clear;
        private Button AB_add;
        private Button DB_clear;
        private Button DB_delete;
        private ComboBox D_type;
        private TextBox D_search;
        private Label Lable8;
        private Label Lable7;
        private DataGridView D_data;
        private Label label10;
        private Label label9;
        private TextBox A_cost;
        private Label label11;
        private ComboBox E_type;
        private TextBox E_cost;
        private TextBox E_rent;
        private TextBox E_copy;
        private TextBox E_search;
        private Label cost;
        private Label E_actor;
        private Label label;
        private DataGridView dataGridView4;
        private Button E_cancel;
        private TextBox M_search;
        private TextBox A_rent;
        private TextBox A_copy;
        private Label label7;
        private Label label2;
        private Label label1;
        private NumericUpDown S_max_copy;
        private NumericUpDown S_mini_rent;
        private NumericUpDown S_mini_copy;
        private NumericUpDown S_max_rent;
        private NumericUpDown S_mini_cost;
        private NumericUpDown S_max_cost;
        private Label label13;
        private Label label12;
        private Label label8;
        private NumericUpDown D_mini_copy;
        private NumericUpDown D_max_copy;
        private NumericUpDown D_mini_rent;
        private NumericUpDown D_mini_cost;
        private NumericUpDown D_max_rent;
        private NumericUpDown D_man_cost;
        private Button EB_change;
    }
}
