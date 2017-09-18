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
    public partial class remove : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\josep\Desktop\testName.mdf;Integrated Security=True;Connect Timeout=30");
        public remove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from infoTable where name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
