using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            double gst = 0;
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
            //label5 is for price total
            label5.Text = reader.GetString(0);
            reader.Close();
            string qs = "select sum(discount) from podetails";
            cmd = new MySqlCommand(qs, con);
            cmd.ExecuteNonQuery();
            MySqlDataReader reader1 = cmd.ExecuteReader();
            reader1.Read();
            //label6 is for total discount  1.26 1.31  2.59  1.6956  3.576  0.795       6.06  2.59
            label6.Text = reader1.GetString(0);
            reader1.Close();
            con.Close();
            double a = Double.Parse(label5.Text);
            double b = Double.Parse(label6.Text);
            //label8 is for total - discount
            label8.Text = (a - b).ToString();
            con.Close();
            //new label for final total
            //getting sum of all total and discount with same gst



            string q1 = "select sum(total),sum(discount),sgst,cgst from podetails group by sgst";
            con.Open();
            //cmd = new MySqlCommand(q1, con);
            DataTable table1 = new DataTable();
            da = new MySqlDataAdapter(q1, con);
            da.Fill(table1);
            //dataGridView1.DataSource = table;
            // Assume that you have fetched the data from your MySQL table and stored it in a DataTable called "myDataTable"

            // Loop through each row in the DataTable
            // Assume that you have fetched the data from your MySQL table and stored it in a DataTable called "myDataTable"

            // Loop through each row in the DataTable
            for (int i = 0; i < table1.Rows.Count; i++)
            {
                // Access the current row
                DataRow row = table1.Rows[i];
                for (int j = 0; j < table1.Columns.Count; i++)
                {
                    DataColumn c = table1.Columns[j];
                    // Access the values in each column of the row
                    //in id = Convert.ToInt32(row["total"]);
                    //string name = row["name"].ToString();
                    //int age = Convert.ToInt32(row["age"]);

                    double to = Convert.ToDouble(row[c]);
                    j++;
                    c = table1.Columns[j];
                    double di = Convert.ToDouble(row[c]);
                    //calculating taxable amount
                    double ta = to - di;
                    // calculating gst
                    j++;
                    c = table1.Columns[j];
                    gst = gst + (ta * Convert.ToDouble(row[c])) / 100;
                    break;
                }
                
            }

            // Assume that you have fetched the data from your MySQL table and stored it in a DataTable called "myDataTable"

            // Loop through each row in the DataTable
            /*foreach (DataRow row in myDataTable.Rows)
            {
                // Loop through each column in the row
                foreach (DataColumn column in myDataTable.Columns)
                {
                    // Access the value of the current cell in the row
                    object cellValue = row[column];

                    // Do something with the cell value here...
                    Console.WriteLine("Cell value: " + cellValue);
                }
            }*/


            //dr = cmd.ExecuteReader();

            /*if (dr.HasRows)
            {
                while (dr.Read())
                {
                    double to = (double)dr[0];
                    double di = (double)dr[1];
                    //calculating taxable amount
                    double ta = to - di;
                    // calculating gst
                    gst = gst + (ta * (double)dr[2]) / 100;
                    //combobox_1p.Items.Add(dr[0].ToString());
                    // a = dr[1].ToString();
                    //string b = dr[2].ToString();
                    //tb1.Text = b;
                    // tb1.Text = (a + b).ToString();
                }
                dr.Close();
            }

            dr.Close();*/
            double du = Double.Parse(label8.Text);
            gst = gst + gst + du;
            ft.Text = gst.ToString();
            con.Close();

            //select sum(total) from prj131lifeline.podetails group by po_id;
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
            string a;
            MySqlDataReader dr;
            cmd = new MySqlCommand("select count(*) from podetails", con);
            con.Open();
            dr = cmd.ExecuteReader();
            dr.Read();

                    // a = dr[1].ToString();
                    //string b = dr[2].ToString();
                    //tb1.Text = b;
                    // tb1.Text = (a + b).ToString();
            if (Convert.ToInt32(dr[0]) != 0)
            {
                con.Close();
                updatedata();
            }
            //dr.Close();
            con.Close();
            //a = Convert.ToInt16(reader1.GetString(0));
           // reader1.Close();
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
            if (dataGridView1.SelectedRows.Count > 0)
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
