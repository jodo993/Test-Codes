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
                Microsoft.Office.Interop.Excel.Workbook sheet = excel.Workbooks.Open("C:\\testSheet.xlsx");
                Microsoft.Office.Interop.Excel.Worksheet x = excel.ActiveSheet as Microsoft.Office.Interop.Excel.Worksheet;

                Excel.Range userRange = x.UsedRange;
                int count = userRange.Rows.Count;

                int add = count + 1;
                x.Cells[add, 1] = "Total Rows " + count;


                //x.Range["A2"].Value = textBox1.Text;
                //x.Range["B2"].Value = textBox2.Text;
                //x.Range["C2"].Value = textBox3.Text;
                //x.Range["D2"].Value = textBox4.Text;
                //x.Range["E2"].Value = textBox5.Text;
                //x.Range["F2"].Value = DateTime.Now;

                int row = 1;
                int column = 1;

                //while (x.Cells != null)
                //    row = row + 1;

                label1.Text = row.ToString();

                x.Cells[row, column] = textBox1.Text;
                column += 1;
                x.Cells[row, column] = textBox2.Text;
                column += 1;
                x.Cells[row, column] = textBox3.Text;
                column += 1;
                x.Cells[row, column] = textBox4.Text;
                column += 1;
                x.Cells[row, column] = textBox5.Text;
                column += 1;
                x.Cells[row, column] = DateTime.Now;
                column += 1;


                sheet.Close(true, Type.Missing, Type.Missing);
                excel.Quit();
            }
            catch (Exception)
            {
                MessageBox.Show("Try again");
            }
        }
    }
}
