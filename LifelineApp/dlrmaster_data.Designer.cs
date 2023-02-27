namespace LifelineApp
{
    partial class dlrmaster_data
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
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_dlrmaster_data = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dlrmaster_data)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(627, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD DEALER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgv_dlrmaster_data
            // 
            this.dgv_dlrmaster_data.AllowUserToAddRows = false;
            this.dgv_dlrmaster_data.AllowUserToDeleteRows = false;
            this.dgv_dlrmaster_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_dlrmaster_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dlrmaster_data.Location = new System.Drawing.Point(28, 26);
            this.dgv_dlrmaster_data.Name = "dgv_dlrmaster_data";
            this.dgv_dlrmaster_data.ReadOnly = true;
            this.dgv_dlrmaster_data.RowTemplate.Height = 25;
            this.dgv_dlrmaster_data.Size = new System.Drawing.Size(1121, 344);
            this.dgv_dlrmaster_data.TabIndex = 3;
            this.dgv_dlrmaster_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dlrmaster_data_CellContentClick);
            this.dgv_dlrmaster_data.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dlrmaster_data_CellDoubleClick);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(377, 399);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 44);
            this.button3.TabIndex = 50;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dlrmaster_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 518);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_dlrmaster_data);
            this.Name = "dlrmaster_data";
            this.Text = "dlrmaster_data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dlrmaster_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dlrmaster_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button3;
        public DataGridView dgv_dlrmaster_data;
    }
}