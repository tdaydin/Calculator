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
        double number;
        string process;
        int round = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void bOne_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "1";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "1";
            }
        }

        private void bTwo_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "2";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "2";
            }
        }

        private void bThree_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "3";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "3";
            }
        }

        private void bFour_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "4";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "4";
            }
        }

        private void bFive_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "5";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "5";
            }
        }

        private void bSix_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "6";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "6";
            }
        }

        private void bSeven_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "7";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "7";
            }
        }

        private void bEight_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "8";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "8";
            }
        }

        private void bNine_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = "9";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "9";
            }
        }

        private void bZero_Click(object sender, EventArgs e)
        {
            if (tbNumber.Text == null)
            {
                tbNumber.Text = null; //tbNumber.Text + "0";
            }
            else
            {
                tbNumber.Text = tbNumber.Text + "0";
            }
        }

        private void bClear_Click(object sender, EventArgs e)
        {
            lbHistory.Items.Clear();
            tbNumber.Clear();
        }

        private void bEqual_Click(object sender, EventArgs e)
        {
            double number2 = Convert.ToDouble(tbNumber.Text);
            double result;

            switch (process)
            {
                case ("+"):
                    result = Math.Round((number + number2), round);
                    tbNumber.Text = Convert.ToString(result);
                    lbHistory.Items.Add(number + " + " + number2 + " = " + result);
                    break;
                case ("-"):
                    result = Math.Round((number - number2), round);
                    tbNumber.Text = Convert.ToString(result);
                    lbHistory.Items.Add(number + " - " + number2 + " = " + result);
                    break;
                case ("*"):
                    result = Math.Round((number * number2), round);
                    tbNumber.Text = Convert.ToString(result);
                    lbHistory.Items.Add(number + " * " + number2 + " = " + result);
                    break;
                case ("/"):
                    result = Math.Round((number / number2), round);
                    tbNumber.Text = Convert.ToString(result);
                    lbHistory.Items.Add(number + " / " + number2 + " = " + result);
                    break;
                case ("^"):
                    result = Math.Round(Math.Pow(number,number2), round);
                    tbNumber.Text = Convert.ToString(result);
                    lbHistory.Items.Add(number + " ^ " + number2 + " = " + result);
                    break;
                case ("mod"):
                    result = Math.Round((number % number2), round);
                    tbNumber.Text = Convert.ToString(result);
                    lbHistory.Items.Add(number + " % " + number2 + " = " + result);
                    break;
                default:
                    result = 0;
                    break;
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(tbNumber.Text);
            tbNumber.Clear();
            process = "+";
        }

        private void bMinus_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(tbNumber.Text);
            tbNumber.Clear();
            process = "-";
        }

        private void bMultip_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(tbNumber.Text);
            tbNumber.Clear();
            process = "*";
        }

        private void bDiv_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(tbNumber.Text);
            tbNumber.Clear();
            process = "/";
        }

        private void bPower_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(tbNumber.Text);
            tbNumber.Clear();
            process = "^";
        }

        private void bSqrt_Click(object sender, EventArgs e)
        {
            double result;
            number = Convert.ToDouble(tbNumber.Text);
            result = Math.Round(Math.Pow(number, 0.5), round);
            tbNumber.Text = Convert.ToString(result);
            lbHistory.Items.Add(number + " ^ " + "(1/2)" + " = " + result);
            tbNumber.Text = Convert.ToString(result);
        }

        private void bMod_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(tbNumber.Text);
            tbNumber.Clear();
            process = "mod";
        }
    }
}
