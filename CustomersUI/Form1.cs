using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CustomersUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_get_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            //modify this accordinglly to your local setup 
            string connectionString = "Server=ACCROM-F1CQP73\\SQL2017;Database=Demo;Trusted_connection=true;";
            string query = "select * from Customer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            //copy of database
            DataSet set = new DataSet();

            adapter.Fill(set, "Customer");

            dataGridView1.DataSource = set.Tables["Customer"];
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ACCROM-F1CQP73\\SQL2017;Database=Demo;Trusted_connection=true;";
            string query = "select * from Customer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            //copy of database
            DataSet set = new DataSet();

            adapter.Fill(set, "Customer");

            set.Tables["Customer"].Rows[dataGridView1.CurrentRow.Index].Delete();

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Customer"]);

            dataGridView1.DataSource = set.Tables["Customer"];


        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ACCROM-F1CQP73\\SQL2017;Database=Demo;Trusted_connection=true;";
            string query = "select * from Customer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            //copy of database
            DataSet set = new DataSet();

            adapter.Fill(set, "Customer");

            //update with data view 
            DataView view = set.Tables["Customer"].DefaultView;
            view.AllowEdit = true;
            view[dataGridView1.CurrentRow.Index].BeginEdit();
            view[dataGridView1.CurrentRow.Index]["CustomerNumber"] = dataGridView1.CurrentRow.Cells[1].Value;
            view[dataGridView1.CurrentRow.Index]["FirstName"] = dataGridView1.CurrentRow.Cells[2].Value;
            view[dataGridView1.CurrentRow.Index]["LastName"] = dataGridView1.CurrentRow.Cells[3].Value;
            view[dataGridView1.CurrentRow.Index].EndEdit();
            dataGridView1.DataSource = view;

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Customer"]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
