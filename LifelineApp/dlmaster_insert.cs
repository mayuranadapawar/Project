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
using System.Windows.Forms.VisualStyles;

namespace LifelineApp
{
    public partial class dlmaster_insert : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        DataTable dt = new DataTable("dlrmaster");
        MySqlCommand cmd;
        public dlmaster_insert()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dlrmaster_data dl = new dlrmaster_data();
            dl.show();

        }

        private void dlmaster_insert_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            string name = textBox1.Text;
            int flag = Int32.Parse(textBox2.Text);
            string address = textBox3.Text;
            string reg_usr = textBox4.Text;
            string dlr_no = textBox5.Text;
            string gstno = textBox6.Text;
            string panno = textBox7.Text;
            string contact = textBox8.Text;
            string online_bcup = textBox9.Text;


            string s = "insert into dlrmaster(name,flag,addr,reg_usr,dlrno,gstno,panno,contact,online_bckup_flag) values('" + name + "'," + flag + ",'" + address + "','" + reg_usr + "','" + dlr_no + "','" + gstno + "','" + panno + "','" + contact + "','" + online_bcup + "')";
            cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Delear  details inserted");
            con.Close();

        }
    }
}
