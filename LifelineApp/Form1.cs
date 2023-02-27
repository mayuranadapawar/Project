using MySql.Data.MySqlClient;
using System.Data;


namespace LifelineApp
{
    public partial class Form1 : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        
       
        DataTable dt = new DataTable("usrmaster");
   
        public Form1()
        {
            InitializeComponent();
          
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string u = textBox1.Text;
                string p = textBox2.Text;
                
                string q = "select * from usrmaster WHERE usr='" + u + "' AND pwd='" + p + "'";
                MySqlDataAdapter da = new MySqlDataAdapter(q, con);
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    globals.username = dt.Rows[0]["usr"].ToString();
                    globals.password = dt.Rows[0]["pwd"].ToString();

                    form_dashboard f2 = new form_dashboard();
                    this.Hide();
                    f2.Show();

                }
                else
                {
                    MessageBox.Show("Envalid User-Id or Password");
                }
                
                
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                con.Close();
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}