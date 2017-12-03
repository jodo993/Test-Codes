using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string first = textBox1.Text;
            string second = textBox2.Text;
            string third = textBox3.Text;

            List<string> firstList = new List<string>();
            List<string> secondList = new List<string>();
            List<string> thirdList = new List<string>();

            double numWord = 0.0;
            foreach (string word in first.Split())
            {
                firstList.Add(word);
                numWord++;
            }

            double numWord2 = 0.0;
            foreach (string word2 in second.Split())
            {
                secondList.Add(word2);
                numWord2++;
            }

            double numWord3 = 0.0;
            foreach (string word3 in third.Split())
            {
                secondList.Add(word3);
                numWord3++;
            }

            label1.Text = numWord.ToString();
            label2.Text = numWord2.ToString();
            label7.Text = numWord3.ToString();

            secondList.AddRange(thirdList);

            double totalWords = 0.0;
            totalWords = numWord + numWord2;

            double matches = 0.0;

            for (int i = 0; i < numWord; i++)
            {
                if (secondList.Contains(firstList[i]))
                    matches++;
            }
            matches = matches * 2;

            label3.Text = "word matched: " + matches.ToString();

            double percentMatch = 0.0;
            percentMatch = (matches / totalWords) * 100;
            if (radioButton1.Checked)
                percentMatch = percentMatch - 3.33;
            percentMatch = Math.Round(percentMatch, 2);
            label4.Text = percentMatch.ToString() + "% of the sentences matched.";
            label5.Text = "total words: " + totalWords.ToString();

            if (percentMatch > 33.32)
                label8.Text = "good match";
            else
                label8.Text = "bad match";
        }
    }
}
