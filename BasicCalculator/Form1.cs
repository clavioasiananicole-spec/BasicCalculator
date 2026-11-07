using CalculatorPrivateAssembly;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOperator.SelectedIndex = 0;
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float num1, num2, result;

            if (!float.TryParse(txtNum1.Text, out num1) ||
                !float.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            switch (cmbOperator.Text)
            {
                case "+":
                    result = BasicComputation.Addition(num1, num2);
                    break;
                case "-":
                    result = BasicComputation.Subtraction(num1, num2);
                    break;
                case "*":
                    result = BasicComputation.Multiplication(num1, num2);
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.");
                        return;
                    }
                    result = BasicComputation.Division(num1, num2);
                    break;
                default:
                    return;
            }

            lblTotal.Text = result.ToString();
        }
    }


}
