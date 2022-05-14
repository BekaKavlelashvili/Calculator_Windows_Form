using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        float num, ans;
        int count;
        public Form1()
        {
            InitializeComponent();          
        }
           
        private void Zero_Click(object sender, EventArgs e)
        {
            OutputText.Text += Zero.Text;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            Calculate();
            OutputText.Clear();
            OutputText.Text = ans.ToString();
        }

        private void Six_Click(object sender, EventArgs e)
        {
            OutputText.Text += Six.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {

            OutputText.Text += Three.Text;
        }

        private void Point_Click(object sender, EventArgs e)
        {
            OutputText.Text += Point.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            OutputText.Text += Four.Text;
        }

        private void One_Click(object sender, EventArgs e)
        {

            OutputText.Text += One.Text;

        }

        private void Two_Click(object sender, EventArgs e)
        {

            OutputText.Text += Two.Text;

        }
        private void Five_Click(object sender, EventArgs e)
        {

            OutputText.Text += Five.Text;

        }
        private void Eight_Click(object sender, EventArgs e)
        {

            OutputText.Text += Eight.Text;

        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            num = float.Parse(OutputText.Text);
            OutputText.Clear();
            OutputText.Focus();
            count = 1;
            label1.Text = num.ToString() + "+";
        }
        private void SubstrictionButton_Click(object sender, EventArgs e)
        {
            num = float.Parse(OutputText.Text);
            OutputText.Clear();
            OutputText.Focus();
            count = 2;
            label1.Text = num.ToString() + "-";
        }
        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            num = float.Parse(OutputText.Text);
            OutputText.Clear();
            OutputText.Focus();
            count = 3;
            label1.Text = num.ToString() + "X";
        }
        private void Seven_Click(object sender, EventArgs e)
        {

            OutputText.Text += Seven.Text;

        }
        private void Nine_Click(object sender, EventArgs e)
        {

            OutputText.Text += Nine.Text;

        }
        private void DevideButton_Click(object sender, EventArgs e)
        {
            num = float.Parse(OutputText.Text);
            OutputText.Clear();
            OutputText.Focus();
            count = 4;
            label1.Text = num.ToString() + "/";
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputText.Clear();
        }
        private void PercentButton_Click(object sender, EventArgs e)
        {
            num = float.Parse(OutputText.Text);
            OutputText.Clear();
            OutputText.Focus();
            count = 5;
            label1.Text = num.ToString() + "%";
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (OutputText.TextLength > 0)
            {
                OutputText.Text = OutputText.Text.Substring(0, OutputText.TextLength - 1);
            }
            else
            {
                MessageBox.Show("No Number");
            }
        }

       
        public void Calculate()
        {
            if (count == 1)
            {
                ans = num + float.Parse(OutputText.Text);
                OutputText.Text = ans.ToString();
            }
            else
            {
                if (count == 2)
                {
                    ans = num - float.Parse(OutputText.Text);
                    OutputText.Text = ans.ToString();
                }
                else
                {
                    if (count == 3)
                    {
                        ans = num * float.Parse(OutputText.Text);
                        OutputText.Text = ans.ToString();
                    }
                    else
                    {
                        if (count == 4)
                        {
                            ans = num / float.Parse(OutputText.Text);
                            OutputText.Text = ans.ToString();
                        }
                        else
                        {
                            if (count == 5)
                            {
                                ans = (num * float.Parse(OutputText.Text))/100;
                                OutputText.Text = ans.ToString();
                            }
                        }
                    }
                }
            }
        }
    }
}
