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
            this.dgv_product_data = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_data)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_product_data
            // 
            this.dgv_product_data.AllowUserToAddRows = false;
            this.dgv_product_data.AllowUserToDeleteRows = false;
            this.dgv_product_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_product_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product_data.Location = new System.Drawing.Point(21, 48);
            this.dgv_product_data.Name = "dgv_product_data";
            this.dgv_product_data.ReadOnly = true;
            this.dgv_product_data.RowTemplate.Height = 25;
            this.dgv_product_data.Size = new System.Drawing.Size(1229, 277);
            this.dgv_product_data.TabIndex = 0;
            this.dgv_product_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgv_product_data.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_product_data_CellMouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(585, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "ADD PRODUCT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(957, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "UPDATE DETAILS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // back_btn
            // 
            this.back_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.back_btn.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.back_btn.Location = new System.Drawing.Point(281, 383);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(151, 44);
            this.back_btn.TabIndex = 50;
            this.back_btn.Text = "BACK";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // pro_list_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_product_data);
            this.Name = "pro_list_data";
            this.Text = "pro_list_data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.pro_list_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DataGridView dgv_product_data;
        private Button back_btn;
    }
}