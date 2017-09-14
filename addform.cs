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

namespace NameSearch
{
    public partial class addform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\josep\Documents\testName.mdf;Integrated Security=True;Connect Timeout=30");
        public addform()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into infoTable values('" + nametextBox1.Text + "','" + agetextBox2.Text + "','" + gendertextBox3.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Added");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
