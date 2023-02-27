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
    public partial class product_list : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        DataTable dt = new DataTable("prodlist");
        MySqlCommand cmd;



        public product_list()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            
            string name = textBox2.Text;
            string hsn_code = textBox3.Text;
            string pack = textBox4.Text;
            string pack_unit = comboBox1.Text;
            string mfg_cmpny = textBox5.Text;
            string cgst = textBox7.Text;
            string sgst = textBox8.Text;
            string igst = textBox9.Text;
            
            string isonline = comboBox2.Text;

            string s = "insert into prodlist(name,hsn_code,pack,pack_unit,mfg_cmpny,cgst,sgst,igst,isonline) values('" + name + "','" + hsn_code + "','" + pack + "','" + pack_unit + "','" + mfg_cmpny + "','" + cgst + "','" + sgst + "','" + igst + "','" + isonline + "')";
            cmd = new MySqlCommand(s, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("product details inserted");
            con.Close();
        }

        private void product_list_Load(object sender, EventArgs e)
        {

        }

       
    }
}
