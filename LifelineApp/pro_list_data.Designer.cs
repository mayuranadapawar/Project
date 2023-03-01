namespace LifelineApp
{
    partial class pro_list_data
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
            dgv_product_data = new DataGridView();
            button1 = new Button();
            back_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_product_data).BeginInit();
            SuspendLayout();
            // 
            // dgv_product_data
            // 
            dgv_product_data.AllowUserToAddRows = false;
            dgv_product_data.AllowUserToDeleteRows = false;
            dgv_product_data.Anchor = AnchorStyles.None;
            dgv_product_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product_data.Location = new Point(215, 34);
            dgv_product_data.Name = "dgv_product_data";
            dgv_product_data.ReadOnly = true;
            dgv_product_data.RowTemplate.Height = 25;
            dgv_product_data.Size = new Size(1229, 439);
            dgv_product_data.TabIndex = 0;
            dgv_product_data.CellContentClick += dataGridView1_CellContentClick;
            dgv_product_data.CellMouseDoubleClick += dgv_product_data_CellMouseDoubleClick;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1047, 543);
            button1.Name = "button1";
            button1.Size = new Size(174, 44);
            button1.TabIndex = 1;
            button1.Text = "ADD PRODUCT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // back_btn
            // 
            back_btn.Anchor = AnchorStyles.None;
            back_btn.Font = new Font("Segoe UI Emoji", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            back_btn.Location = new Point(526, 543);
            back_btn.Name = "back_btn";
            back_btn.Size = new Size(151, 44);
            back_btn.TabIndex = 50;
            back_btn.Text = "BACK";
            back_btn.UseVisualStyleBackColor = true;
            back_btn.Click += back_btn_Click;
            // 
            // pro_list_data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1640, 688);
            Controls.Add(back_btn);
            Controls.Add(button1);
            Controls.Add(dgv_product_data);
            Name = "pro_list_data";
            Text = "pro_list_data";
            WindowState = FormWindowState.Maximized;
            Load += pro_list_data_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_product_data).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridView dgv_product_data;
        private Button back_btn;
    }
}