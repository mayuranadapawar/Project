﻿using System;
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
    public partial class stock : Form
    {
        MySqlConnection con = new MySqlConnection("server=115.96.168.103;user=prj131;pwd=prj131@lifeline;database=prj131lifeline;port=3306");
        DataTable DataTable = new DataTable();
        MySqlDataAdapter da;
        public stock()
        {
            InitializeComponent();
        }

        private void stock_Load(object sender, EventArgs e)
        {
            con.Open();
            da = new MySqlDataAdapter("SELECT stock.id, prodlist.name, prodlist.hsn_code, prodlist.pack, prodlist.mfg_cmpny, stock.qty, stock.expiry FROM stock INNER JOIN prodlist ON stock.drug_id = prodlist.id", con);
            da.Fill(DataTable);
            dgv_stock.DataSource = DataTable;
            con.Close();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
                string searchTerm = textBox1.Text.ToLower();
                bool rowFound = false;

                foreach (DataGridViewRow row in dgv_stock.Rows)
                {
                    bool rowContainsSearchTerm = false;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchTerm))
                        {
                            rowContainsSearchTerm = true;
                            break;
                        }
                    }

                    if (rowContainsSearchTerm)
                    {
                        // move the CurrencyManager position to the found row
                        ((CurrencyManager)dgv_stock.BindingContext[dgv_stock.DataSource]).Position = row.Index;
                        rowFound = true;
                    }

                    row.Visible = rowContainsSearchTerm;
                }

                if (!rowFound)
                {
                    // display a message if no rows are found
                    MessageBox.Show("No rows matching the search term were found.");
                }
            

        }
    }
}
