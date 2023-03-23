namespace LifelineApp
{
    partial class form_dashboard
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            user_name_set = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_DLR_master = new Button();
            btn_product_list = new Button();
            panel3 = new Panel();
            panel4 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(729, 475);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(user_name_set);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(729, 50);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // user_name_set
            // 
            user_name_set.AutoSize = true;
            user_name_set.ForeColor = Color.White;
            user_name_set.Location = new Point(10, 35);
            user_name_set.Name = "user_name_set";
            user_name_set.Size = new Size(0, 15);
            user_name_set.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(12, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 28);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlDark;
            panel2.Controls.Add(btn_DLR_master);
            panel2.Controls.Add(btn_product_list);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 50);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(729, 50);
            panel2.TabIndex = 1;
            // 
            // btn_DLR_master
            // 
            btn_DLR_master.BackColor = SystemColors.ControlDark;
            btn_DLR_master.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btn_DLR_master.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btn_DLR_master.FlatStyle = FlatStyle.Flat;
            btn_DLR_master.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_DLR_master.ForeColor = SystemColors.ControlText;
            btn_DLR_master.Location = new Point(112, 0);
            btn_DLR_master.Margin = new Padding(0);
            btn_DLR_master.Name = "btn_DLR_master";
            btn_DLR_master.Size = new Size(114, 50);
            btn_DLR_master.TabIndex = 1;
            btn_DLR_master.Text = "DLR Master";
            btn_DLR_master.UseVisualStyleBackColor = false;
            btn_DLR_master.Click += btn_DLR_master_Click;
            // 
            // btn_product_list
            // 
            btn_product_list.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 64, 64);
            btn_product_list.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 192, 192);
            btn_product_list.FlatStyle = FlatStyle.Flat;
            btn_product_list.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_product_list.Location = new Point(0, 0);
            btn_product_list.Margin = new Padding(0);
            btn_product_list.Name = "btn_product_list";
            btn_product_list.Size = new Size(114, 50);
            btn_product_list.TabIndex = 0;
            btn_product_list.Text = "Product List";
            btn_product_list.UseVisualStyleBackColor = true;
            btn_product_list.Click += btn_product_list_Click;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 100);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(729, 325);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(192, 64, 0);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 425);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(729, 50);
            panel4.TabIndex = 3;
            // 
            // form_dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 475);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "form_dashboard";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += form_dashboard_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button btn_product_list;
        private Panel panel3;
        private Panel panel4;
        private Label user_name_set;
        private Button btn_DLR_master;
        private PictureBox pictureBox1;
    }
}