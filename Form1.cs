using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AccessDBTest
{
    public partial class Form1 : Form
    {
        // Use by this form only, global
        private OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();

            // Connect to database                                                        Possible new line after dont copy and paste copy and type
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=T:\MainDB.accdb;Persist Security Info=False;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                checkConnection.Text = "Success";

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Main";
                command.CommandText = query;

                OleDbDataReader reader = command.ExecuteReader();
                while(reader.Read())
                {
                    comboBox1.Items.Add(reader["FullName"].ToString());
                }

                connection.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string name = textBox1.Text;
                int lunchNumber = int.Parse(textBox2.Text);
                int tagNumber = int.Parse(textBox3.Text);

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Main (FullName,LunchID,Tag) values('" + name + "','" + lunchNumber + "','" + tagNumber + "')";

                command.ExecuteNonQuery();
                MessageBox.Show("Saved.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error." + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string name = textBox1.Text;
                int lunchNumber = int.Parse(textBox2.Text);
                int tagNumber = int.Parse(textBox3.Text);

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Main set FullName='" + name + "' ,Tag='" + tagNumber + "' where LunchID=" + lunchNumber + "";
                MessageBox.Show(query);
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Updated.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                int lunchNumber = int.Parse(textBox2.Text);

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "delete from Main where lunchID=" + lunchNumber + "";
                command.CommandText = query;

                command.ExecuteNonQuery();
                MessageBox.Show("Deleted.");

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Main";
                command.CommandText = query;

                OleDbDataAdapter da = new OleDbDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string selection = comboBox1.Text;

            connection.Open();
            checkConnection.Text = "Success";

            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            string query = "select * from Main where FullName='" + selection + "'";
            command.CommandText = query;

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader["lunchID"].ToString());
            }

            connection.Close();
        }
    }
}
