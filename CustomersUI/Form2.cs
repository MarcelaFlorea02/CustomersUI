﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace CustomersUI
{
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 parent)
        {
            form1 = parent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=ACCROM-F1CQP73\\SQL2017;Database=Demo;Trusted_connection=true;";
            string query = "select * from Customer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);

            //copy of database
            DataSet set = new DataSet();

            adapter.Fill(set, "Customer");

            DataRow row = set.Tables["Customer"].NewRow();
            row["CustomerNumber"] = int.Parse(textBox1.Text);
            row["FirstName"] = textBox2.Text;
            row["LastName"] = textBox3.Text;

            set.Tables["Customer"].Rows.Add(row);

            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Update(set.Tables["Customer"]);

            form1.LoadData();

            this.Close();

        }
    }
}
