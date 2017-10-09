using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WriteToExcelTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("test.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                //Excel.Range userRange = x.UsedRange;
                //int count = userRange.Rows.Count;

                //int add = count + 1;
                //x.Cells[add, 1] = "Total Rows " + count;


                //x.Range["A2"].Value = textBox1.Text;
                //x.Range["B2"].Value = textBox2.Text;
                //x.Range["C2"].Value = textBox3.Text;
                //x.Range["D2"].Value = textBox4.Text;
                //x.Range["E2"].Value = textBox5.Text;
                //x.Range["F2"].Value = DateTime.Now;
     
                int row = 2;
                int column = 1;

                while (x.Cells[row,column].Value != null)
                    row = row + 1;

                x.Cells[row, column].Value = textBox1.Text;
                column += 1;
                x.Cells[row, column].Value = textBox2.Text;
                column += 1;
                x.Cells[row, column].Value = textBox3.Text;
                column += 1;
                x.Cells[row, column].Value = textBox4.Text;
                column += 1;
                x.Cells[row, column].Value = textBox5.Text;
                column += 1;
                x.Cells[row, column].Value = DateTime.Now;
                
                label1.Visible = false;

                MessageBox.Show("DOne");
                

                sheet.Close(true, Type.Missing, Type.Missing);
                excel.Quit();
            }
            catch (Exception)
            {
                MessageBox.Show("Try again");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("test.xlsx");
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            // finding row length
            Excel.Range userRange = x.UsedRange;
            int countRows = userRange.Rows.Count;
            int add = countRows + 2;

            x.Cells[add, 1] = "Total Rows " + countRows;
            sheet.Close(true, Type.Missing, Type.Missing);
            excel.Quit();

            MessageBox.Show("done");
            label6.Text = countRows.ToString();




            //int item = int.Parse(removeTB.Text);

            //bool found = false;
            //int row = 1;
            //int column = 4;
            //while ( !found )
            //{
            //    x.Cells[row, column] != item
            //    row = row + 1;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = 0;
            //timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            string item = searchTB.Text;

            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("test.xlsx");
            Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

            // finding row length
            Excel.Range userRange = x.UsedRange;
            int countRows = userRange.Rows.Count;
            bool found = false;
            string values = "";
            //double itemz = double.Parse(item);
            //label7.Text = x.Cells[2, 3].Value;

            //if (item == label7.Text)
            //{
            //    MessageBox.Show("Ture");
            //}
            //else
            //    MessageBox.Show("Flase");

            for (int i = 1; i < countRows; i++)
            {
                progressBar1.Value = (i/countRows) * 100;
                string num = x.Cells[i, 4].Value.ToString() ;
                if (num == item)
                {
                    found = true;
                    
                    progressBar1.Value = (i/countRows) * 100;
                    percentLabel.Text = ((i / countRows) * 100).ToString();
                    //timer1.Stop();
                    MessageBox.Show("found");
                    break;
                }
                else
                {
                    label7.Text = i.ToString();
                }
                    

            }
            timer1.Stop();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // to check progress bar
        private void progessbtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            int count = 0;
            while (count < 100)
            {
                progressBar1.Value = count;
                count++;
                percentLabel.Text = percentLabel.Text + count.ToString() + "%";
            }
            //else
            //    timer1.Stop();
        }
    }
}
