﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace mySQL2PC
{
    public partial class Form1 : Form
    {

        private SqlConnection sqlConnection=null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlBDpc2"].ConnectionString);
            sqlConnection.Open();
            if (sqlConnection.State == ConnectionState.Open)
            {
                MessageBox.Show("Вы подключены. Все ОК.", "Connection");
            }
            else
            {
                MessageBox.Show("ERROR", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}