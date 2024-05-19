using System;
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
        private SqlConnection sqlConnection1 = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlBDpc2"].ConnectionString);
                sqlConnection.Open();
                MessageBox.Show("OK", "Connection BD2", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                sqlConnection1 = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlBDpc1"].ConnectionString);
                sqlConnection1.Open();
                MessageBox.Show("OK", "Connection BD1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("ERROR", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
