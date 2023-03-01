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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LifelineApp
{
    public partial class podetail : Form
    {

        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        MySqlDataAdapter da;
        DataTable dt = new DataTable("dlrmaster");
        MySqlCommand cmd;
        MySqlDataReader dr;


        string ProductID = string.Empty;



        public podetail()
        {
            InitializeComponent();
        }

        private void combobox_1p_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (combobox_1p.SelectedIndex != -1)
            {
                cmd = new MySqlCommand("select id from prodlist where name='" + combobox_1p.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ProductID = dr[0].ToString();
                    }
                    dr.Close();
                }
                dr.Close();
                con.Close();
            }
            textBox_pid.Text = "" + ProductID;
        }

        private void podetail_Load(object sender, EventArgs e)
        {

            product();
            po_master1 pom = new po_master1();
            DataGridView dataGridView1 = pom.dataGridView1;

        }

        public void product()
        {
            cmd = new MySqlCommand("select distinct name from prodlist", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    combobox_1p.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            dr.Close();
            con.Close();
        }

        private void comboBox_d_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string s = "insert into podetails(po_id,batch_no,expiry,mrp,rate,qty,total,discount,free_qty) values('" + textBox_pid.Text + "'," + textBox1_batch.Text + ",'" + textBox2_ex.Text + "','" + textBox3_MRP.Text + "','" + textBox4_rate.Text + "','" + textBox5_qty.Text + "','" + textBox_total.Text + "','" + textBox6_dis.Text + "','" + textBox7_free.Text + "')";
            cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delear  details inserted");
            con.Close();

            this.Close();
            po_master1 p = new po_master1();
            p.Show();

        }

        private void textBox5_qty_Leave(object sender, EventArgs e)
        {
            int a = Int32.Parse(textBox4_rate.Text);
            int b = Int32.Parse(textBox5_qty.Text);
            int total = a * b;
            textBox_total.Text = "" + total;
        }
    }
}
