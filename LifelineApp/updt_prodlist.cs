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
    public partial class updt_prodlist : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        
        MySqlDataAdapter da;
        DataTable dt = new DataTable("prodlist");
        MySqlCommand cmd;
        
        public updt_prodlist()
        {
            InitializeComponent();
        }

        private void updt_prodlist_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1_id.Text!=""&&textBox2_name.Text!=""&&textBox3_hsn.Text!=""&&textBox4_pack.Text!=""&& comboBox1_unit.Text!=""&& textBox5_mfg.Text!=""&&textBox7_cgst.Text!=""&&textBox8_sgst.Text!=""&&textBox9_igst.Text!=""&& comboBox2_isonline.Text!="")
            {
                con.Open();
                int id_1 = Int32.Parse(textBox1_id.Text);
                string name_2 = textBox2_name.Text;
                string hsn_3 = textBox3_hsn.Text;
                string pack_4 = textBox4_pack.Text;
                string packunit_5=comboBox1_unit.Text;
                string mfg_6 = textBox5_mfg.Text;
                string cgst_7 = textBox7_cgst.Text;
                string sgst_8 = textBox8_sgst.Text;
                string igst_9 = textBox9_igst.Text;
                string isonline_10 = comboBox2_isonline.Text;

                string s = "update prodlist SET name='" + name_2 + "',hsn_code='" + hsn_3 + "',pack='" + pack_4 + "',pack_unit='" + packunit_5 + "',mfg_cmpny='" + mfg_6 + "',cgst='" + cgst_7 + "',sgst='" + sgst_8 + "',igst='" + igst_9 + "',isonline='" +isonline_10 + "' where id =" + id_1;
                cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA update SUCCESFULLY");
                
                con.Close();
                this.Close();
                pro_list_data p = new pro_list_data();
                p.data();
                p.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
