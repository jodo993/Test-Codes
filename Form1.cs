using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQL_Dynamic_Table_Creation
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\josep\Documents\TableTest.mdf;Integrated Security=True;Connect Timeout=30");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            string third = textBox3.Text;
            string fourth = textBox4.Text;
            string fifth = textBox5.Text;
            string name = textBox6.Text;

            connection.Open();

            SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "CREATE TABLE " + name + "("
                                + first + " int,"
                                + second + " int,"
                                + third + " int,"
                                + fourth + " int,"
                                + fifth + " int,"
                                + ")";
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Success!");
        }
    }
}
