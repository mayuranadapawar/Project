using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace LifelineApp
{
    public partial class pro_list_data : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");

        MySqlDataAdapter da;
        DataTable dt = new DataTable("prodlist");

        public pro_list_data()
        {
            InitializeComponent();
        }
        public void show()
        {
            con.Open();
            da = new MySqlDataAdapter("select * from prodlist", con);
            da.Fill(dt);
            dgv_product_data.DataSource = dt;
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            product_list pl1 = new product_list();
            pl1.Show();
            this.Hide();
        }

        private void pro_list_data_Load(object sender, EventArgs e)
        {
            data();
        }

        public void data()
        {
            con.Open();
            da = new MySqlDataAdapter("select * from prodlist", con);
            da.Fill(dt);
            dgv_product_data.DataSource = dt;
            con.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            updt_prodlist pl2 = new updt_prodlist();
            pl2.Show();
            this.Hide();
        }
        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_dashboard fd1 = new form_dashboard();
            fd1.Show();

        }
        private void dgv_product_data_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgv_product_data.Rows.Count != 0)
            {
                updt_prodlist up1 = new updt_prodlist();
                up1.textBox1_id.Text = this.dgv_product_data.CurrentRow.Cells[0].Value.ToString();
                up1.textBox2_name.Text = this.dgv_product_data.CurrentRow.Cells[1].Value.ToString();
                up1.textBox3_hsn.Text = this.dgv_product_data.CurrentRow.Cells[2].Value.ToString();
                up1.textBox4_pack.Text = this.dgv_product_data.CurrentRow.Cells[3].Value.ToString();
                up1.comboBox1_unit.Text = this.dgv_product_data.CurrentRow.Cells[4].Value.ToString();
                up1.textBox5_mfg.Text = this.dgv_product_data.CurrentRow.Cells[5].Value.ToString();
                up1.textBox7_cgst.Text = this.dgv_product_data.CurrentRow.Cells[6].Value.ToString();
                up1.textBox8_sgst.Text = this.dgv_product_data.CurrentRow.Cells[7].Value.ToString();
                up1.textBox9_igst.Text = this.dgv_product_data.CurrentRow.Cells[8].Value.ToString();
                up1.comboBox2_isonline.Text = this.dgv_product_data.CurrentRow.Cells[11].Value.ToString();
                up1.ShowDialog();
                this.Close();
            }
        }
    }
}
