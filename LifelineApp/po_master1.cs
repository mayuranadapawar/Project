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
    public partial class po_master1 : Form
    {
        public void updatedata()
        {
            con.Open();
            DataTable table = new DataTable();
            string qry = "select po_id,batch_no,expiry,mrp,rate,qty,total,discount,free_qty from podetails";

            da = new MySqlDataAdapter(qry, con);
            da.Fill(table);
            dataGridView1.DataSource = table;
            string q = "select sum(total) from podetails";
            cmd = new MySqlCommand(q, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            label5.Text = reader.GetString(0);
            reader.Close();
            string qs = "select sum(discount) from podetails";
            cmd = new MySqlCommand(qs, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();
            label6.Text = reader1.GetString(0);
            reader1.Close();
            con.Close();
            int a = Int32.Parse(label5.Text);
            int b = Int32.Parse(label6.Text);

            label8.Text = (a - b).ToString();
        }
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
            updatedata();
        }

        public void deler()
        {
            con.Open();
            cmd = new MySqlCommand("select distinct name from dlrmaster", con);
            
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
            //string dateValue = dateTimePicker1.Value.ToString("yyyy-MM-dd");
            string date = dateTimePicker1.Text;
            string s = "insert into pomaster(inc_date,sup_id,sup_bill_no,tr_tp) values('" + date + "','" + sup + "','" + bill + "','" + tr + "')";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox_trtype_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count>0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

           
                // Get the ID of the selected row from the underlying data source
                int id = Convert.ToInt32(selectedRow.Cells["po_id"].Value);
                con.Open();

                string s = "delete from podetails where po_id='" + id + "'";
                cmd = new MySqlCommand(s, con);
                cmd.ExecuteNonQuery();

                con.Close();
                updatedata();
                MessageBox.Show("Record deleted!");

            }
            else 
            {
                MessageBox.Show("Please Select the row first");
            }
        }
    }
}
