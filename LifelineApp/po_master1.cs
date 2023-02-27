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
    public partial class po_master1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        MySqlDataAdapter da;
        
        MySqlCommand cmd;
        MySqlDataReader dr;
        string DelearID = string.Empty;
        

        public po_master1()
        {
            InitializeComponent();
        }

        private void po_master1_Load(object sender, EventArgs e)
        {
           
          
            deler();
            DataTable table = new DataTable();
            table.Columns.Add("DRUG-ID");
            table.Columns.Add("BATCH-NO");
            table.Columns.Add("EXPIRY");
            table.Columns.Add("MRP");
            table.Columns.Add("RATE");
            table.Columns.Add("QTY");
            table.Columns.Add("TOTAL");
            table.Columns.Add("DISCOUNT");
            table.Columns.Add("FREE-QTY");
            
            
            dataGridView1.DataSource = table;


        }
        public void deler()
        {
            cmd = new MySqlCommand("select distinct name from dlrmaster", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    comboBox2.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            dr.Close();
            con.Close();
        }

 

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                cmd = new MySqlCommand("select id from dlrmaster where name='" + comboBox2.Text + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        DelearID = dr[0].ToString();
                    }
                    dr.Close();
                }
                dr.Close();
                con.Close();
            }
            textBox_id.Text = "" + DelearID;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string sup = textBox_id.Text;
            string tr = textBox_trtype.Text;
            string bill = textBox1.Text;
            string dateValue = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string s = "insert into pomaster(sup_id,sup_bill_no,tr_tp) values('" + sup + "','" + bill+ "','" + tr + "')";
            cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("product details inserted");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            podetail pod = new podetail();
            pod.Show();
        }
    }
}
