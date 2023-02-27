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
    public partial class frmUpdte_dlrmaster : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");

        MySqlDataAdapter da;
        DataTable dt = new DataTable("dlrmaster");
        MySqlCommand cmd;
        public frmUpdte_dlrmaster()
        {
            InitializeComponent();
        }

        private void frmUpdte_dlrmaster_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_id_dlr.Text != "" && textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "")
            {
                con.Open();
                int id_dlr = Int32.Parse(txt_id_dlr.Text);
                string name_dlr = textBox1.Text;
                string flag_dlr = textBox2.Text;
                string addr = textBox3.Text;
                string reg = textBox4.Text;
                string dlrno = textBox5.Text;
                string gst = textBox6.Text;
                string panno = textBox7.Text;
                string contact = textBox8.Text;
                string online = textBox9.Text;

                string s = "update dlrmaster SET name='" +name_dlr+ "',flag='" + flag_dlr + "',addr='" + addr + "',reg_usr='" + reg + "',dlrno='" + dlrno + "',gstno='" + gst + "',panno='" + panno + "',contact='" + contact + "',online_bckup_flag='" + online + "'where id =" + id_dlr;
                cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dealer deltails updated SUCCESFULLY");

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dlrmaster_data dl = new dlrmaster_data();
            dl.show();
           

        }
    }
}
