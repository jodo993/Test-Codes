using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            addform newadd = new addform();
            newadd.ShowDialog();
            this.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            update newup = new update();
            newup.ShowDialog();
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            remove newremove = new remove();
            newremove.ShowDialog();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
