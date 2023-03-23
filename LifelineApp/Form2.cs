using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LifelineApp
{

    public partial class form_dashboard : Form
    {
        public form_dashboard()
        {
            InitializeComponent();
        }

        private void btn_product_list_Click(object sender, EventArgs e)
        {
            this.Hide();
            pro_list_data pld = new pro_list_data();
            /*product_list pld = new product_list();*/
            pld.Show();
        }

        private void form_dashboard_Load(object sender, EventArgs e)
        {
            MessageBox.Show("WELCOME " + globals.username);
            user_name_set.Text = globals.username;


        }

        private void btn_DLR_master_Click(object sender, EventArgs e)
        {
            this.Hide();
            dlrmaster_data dlmd = new dlrmaster_data();
            dlmd.Show();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
