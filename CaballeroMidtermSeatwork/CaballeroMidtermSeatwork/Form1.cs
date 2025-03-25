using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaballeroMidtermSeatwork
{
    public partial class Form1 : Form
    {
        private string input = "";
        private double operand1 = 0;
        private double operand2 = 0;
        private char operation;
        private bool isOperationClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void txtDisplay_Click(object sender, EventArgs e)
        {

        }

        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (isOperationClicked)
                {
                    txtDisplay.Text = "";
                    isOperationClicked = false;
                }
                txtDisplay.Text += btn.Text;
            }
        }

        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                if (double.TryParse(txtDisplay.Text, out operand1))
                {
                    operation = btn.Text[0];
                    isOperationClicked = true;
                }
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out operand2))
            {
                double result = 0;
                switch (operation)
                {
                    case '+':
                        result = operand1 + operand2;
                        break;
                    case '-':
                        result = operand1 - operand2;
                        break;
                    case '*':
                        result = operand1 * operand2;
                        break;
                    case '/':
                        if (operand2 != 0)
                            result = operand1 / operand2;
                        else
                        {
                            MessageBox.Show("Cannot divide by zero!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        break;
                }
                txtDisplay.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            operand1 = 0;
            operand2 = 0;
            isOperationClicked = false;
        }

        private void btn0_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn1_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn2_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn3_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn4_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn5_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn6_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn7_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn8_Click(object sender, EventArgs e) { Number_Click(sender, e); }
        private void btn9_Click(object sender, EventArgs e) { Number_Click(sender, e); }

        private void btnAdd_Click(object sender, EventArgs e) { Operator_Click(sender, e); }
        private void btnSubtract_Click(object sender, EventArgs e) { Operator_Click(sender, e); }
        private void btnMultiply_Click(object sender, EventArgs e) { Operator_Click(sender, e); }
        private void btnDivide_Click(object sender, EventArgs e) { Operator_Click(sender, e); }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
