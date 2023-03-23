namespace LifelineApp
{
    partial class podetail
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            combobox_1p = new ComboBox();
            textBox1_batch = new TextBox();
            textBox2_ex = new TextBox();
            textBox6_dis = new TextBox();
            textBox5_qty = new TextBox();
            label5 = new Label();
            label6 = new Label();
            textBox4_rate = new TextBox();
            textBox3_MRP = new TextBox();
            label7 = new Label();
            label8 = new Label();
            textBox7_free = new TextBox();
            label10 = new Label();
            button1 = new Button();
            textBox_total = new TextBox();
            label11 = new Label();
            textBox_pid = new TextBox();
            cb1 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(141, 60);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "PRODUCT";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Location = new Point(144, 120);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 2;
            label3.Text = "BATCH_NO";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Location = new Point(144, 197);
            label4.Name = "label4";
            label4.Size = new Size(76, 15);
            label4.TabIndex = 3;
            label4.Text = "EXPIRY_DATE";
            // 
            // combobox_1p
            // 
            combobox_1p.Anchor = AnchorStyles.None;
            combobox_1p.FormattingEnabled = true;
            combobox_1p.ImeMode = ImeMode.On;
            combobox_1p.Location = new Point(280, 57);
            combobox_1p.Name = "combobox_1p";
            combobox_1p.Size = new Size(150, 23);
            combobox_1p.TabIndex = 4;
            combobox_1p.SelectedIndexChanged += combobox_1p_SelectedIndexChanged;
            // 
            // textBox1_batch
            // 
            textBox1_batch.Anchor = AnchorStyles.None;
            textBox1_batch.ImeMode = ImeMode.On;
            textBox1_batch.Location = new Point(280, 122);
            textBox1_batch.Name = "textBox1_batch";
            textBox1_batch.Size = new Size(150, 23);
            textBox1_batch.TabIndex = 6;
            // 
            // textBox2_ex
            // 
            textBox2_ex.Anchor = AnchorStyles.None;
            textBox2_ex.ImeMode = ImeMode.On;
            textBox2_ex.Location = new Point(280, 196);
            textBox2_ex.Name = "textBox2_ex";
            textBox2_ex.Size = new Size(150, 23);
            textBox2_ex.TabIndex = 7;
            // 
            // textBox6_dis
            // 
            textBox6_dis.Anchor = AnchorStyles.None;
            textBox6_dis.Location = new Point(774, 126);
            textBox6_dis.Name = "textBox6_dis";
            textBox6_dis.Size = new Size(150, 23);
            textBox6_dis.TabIndex = 11;
            // 
            // textBox5_qty
            // 
            textBox5_qty.Anchor = AnchorStyles.None;
            textBox5_qty.Location = new Point(774, 52);
            textBox5_qty.Name = "textBox5_qty";
            textBox5_qty.Size = new Size(150, 23);
            textBox5_qty.TabIndex = 10;
            textBox5_qty.TextChanged += textBox5_qty_TextChanged;
            textBox5_qty.Leave += textBox5_qty_Leave;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Location = new Point(584, 134);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 9;
            label5.Text = "DISCOUNT";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Location = new Point(584, 60);
            label6.Name = "label6";
            label6.Size = new Size(28, 15);
            label6.TabIndex = 8;
            label6.Text = "QTY";
            // 
            // textBox4_rate
            // 
            textBox4_rate.Anchor = AnchorStyles.None;
            textBox4_rate.ImeMode = ImeMode.On;
            textBox4_rate.Location = new Point(283, 350);
            textBox4_rate.Name = "textBox4_rate";
            textBox4_rate.Size = new Size(150, 23);
            textBox4_rate.TabIndex = 15;
            textBox4_rate.FontChanged += textBox4_rate_FontChanged;
            textBox4_rate.TextChanged += textBox4_rate_TextChanged;
            textBox4_rate.Leave += textBox4_rate_Leave;
            textBox4_rate.MouseLeave += textBox4_rate_MouseLeave;
            // 
            // textBox3_MRP
            // 
            textBox3_MRP.Anchor = AnchorStyles.None;
            textBox3_MRP.ImeMode = ImeMode.On;
            textBox3_MRP.Location = new Point(283, 276);
            textBox3_MRP.Name = "textBox3_MRP";
            textBox3_MRP.Size = new Size(150, 23);
            textBox3_MRP.TabIndex = 14;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Location = new Point(144, 358);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 13;
            label7.Text = "RATE";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Location = new Point(144, 281);
            label8.Name = "label8";
            label8.Size = new Size(32, 15);
            label8.TabIndex = 12;
            label8.Text = "MRP";
            // 
            // textBox7_free
            // 
            textBox7_free.Anchor = AnchorStyles.None;
            textBox7_free.Location = new Point(774, 218);
            textBox7_free.Name = "textBox7_free";
            textBox7_free.Size = new Size(150, 23);
            textBox7_free.TabIndex = 18;
            textBox7_free.TextChanged += textBox7_TextChanged;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Location = new Point(584, 226);
            label10.Name = "label10";
            label10.Size = new Size(58, 15);
            label10.TabIndex = 16;
            label10.Text = "FREE-QTY";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Location = new Point(499, 467);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 19;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox_total
            // 
            textBox_total.Anchor = AnchorStyles.None;
            textBox_total.Location = new Point(774, 317);
            textBox_total.Name = "textBox_total";
            textBox_total.Size = new Size(150, 23);
            textBox_total.TabIndex = 21;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Location = new Point(609, 325);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 20;
            label11.Text = "TOTAL";
            // 
            // textBox_pid
            // 
            textBox_pid.Anchor = AnchorStyles.None;
            textBox_pid.Location = new Point(436, 57);
            textBox_pid.Name = "textBox_pid";
            textBox_pid.ReadOnly = true;
            textBox_pid.Size = new Size(15, 23);
            textBox_pid.TabIndex = 22;
            // 
            // cb1
            // 
            cb1.Anchor = AnchorStyles.None;
            cb1.FormattingEnabled = true;
            cb1.Items.AddRange(new object[] { "Percentage", "Cash" });
            cb1.Location = new Point(930, 126);
            cb1.Name = "cb1";
            cb1.Size = new Size(85, 23);
            cb1.TabIndex = 23;
            // 
            // podetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1045, 562);
            Controls.Add(cb1);
            Controls.Add(textBox_pid);
            Controls.Add(textBox_total);
            Controls.Add(label11);
            Controls.Add(button1);
            Controls.Add(textBox7_free);
            Controls.Add(label10);
            Controls.Add(textBox4_rate);
            Controls.Add(textBox3_MRP);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(textBox6_dis);
            Controls.Add(textBox5_qty);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2_ex);
            Controls.Add(textBox1_batch);
            Controls.Add(combobox_1p);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "podetail";
            Text = "podetail";
            WindowState = FormWindowState.Maximized;
            Load += podetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Button button1;
        private Label label11;
        public ComboBox combobox_1p;
        public TextBox textBox1_batch;
        public TextBox textBox2_ex;
        public TextBox textBox6_dis;
        public TextBox textBox5_qty;
        public TextBox textBox4_rate;
        public TextBox textBox3_MRP;
        public TextBox textBox7_free;
        public TextBox textBox_total;
        public TextBox textBox_pid;
        private ComboBox comboBox1;
        private ComboBox cb1;
    }
}