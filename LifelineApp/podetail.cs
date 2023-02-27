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
    public partial class podetail : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        MySqlDataAdapter da;
        DataTable dt = new DataTable("dlrmaster");
        MySqlCommand cmd;
        MySqlDataReader dr;

        string DelearID = string.Empty;
        string ProductID = string.Empty;



        public podetail()
        {
            InitializeComponent();
        }

        private void combobox_1p_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(combobox_1p.SelectedIndex!=-1)
            {
                cmd = new MySqlCommand("select id from prodlist where name='"+combobox_1p.Text+"'", con);
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
            deler();
            product();
            po_master1 pom = new po_master1();
            DataGridView dataGridView1 = pom.dataGridView1;

        }
        public void deler()
        {
            cmd = new MySqlCommand("select distinct name from dlrmaster", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if(dr.HasRows)
            {
                while(dr.Read())
                {
                    comboBox_d.Items.Add(dr[0].ToString());
                }
                dr.Close();
            }
            dr.Close();
            con.Close();
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
            if (comboBox_d.SelectedIndex != -1)
            {
                cmd = new MySqlCommand("select id from dlrmaster where name='" + comboBox_d.Text + "'", con);
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

            textBox_did.Text = "" + DelearID;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }
    }
}
