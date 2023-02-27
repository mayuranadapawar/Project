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

namespace LifelineApp
{
    public partial class dlrmaster_data : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");

        MySqlDataAdapter da;
        DataTable dt = new DataTable("dlrmaster");

        public dlrmaster_data()
        {
            InitializeComponent();
        }
        public void show()
        {
            con.Open();
            da = new MySqlDataAdapter("select * from dlrmaster", con);
            da.Fill(dt);
            dgv_dlrmaster_data.DataSource = dt;
            con.Close();
        }

        private void dgv_dlrmaster_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            dlmaster_insert dl1 = new dlmaster_insert();
            dl1.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void dlrmaster_data_Load(object sender, EventArgs e)
        {
            show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_dashboard fd2 = new form_dashboard();
            fd2.Show();
            this.Hide();

        }

        private void dgv_dlrmaster_data_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_dlrmaster_data.Rows.Count != 0)
            {
                frmUpdte_dlrmaster f = new frmUpdte_dlrmaster();
                f.txt_id_dlr.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[0].Value.ToString();
                f.textBox1.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[1].Value.ToString();
                f.textBox2.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[2].Value.ToString();
                f.textBox3.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[4].Value.ToString();
                f.textBox4.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[5].Value.ToString();
                f.textBox5.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[6].Value.ToString();
                f.textBox6.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[7].Value.ToString();
                f.textBox7.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[8].Value.ToString();
                f.textBox8.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[9].Value.ToString();
                f.textBox9.Text= this.dgv_dlrmaster_data.CurrentRow.Cells[10].Value.ToString();
                f.ShowDialog();
            }
        }
    }
}
