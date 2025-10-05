using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Asignment_2
{
    public partial class CalculatorForm : Form
    {
        List<string> history = new List<string>();
        string studentName = "Sarah Badar"; // Your name

        public CalculatorForm()
        {
            InitializeComponent();
            this.Text = $"Calculator - {studentName}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PerformOperation("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            PerformOperation("/");
        }

        private void PerformOperation(string op)
        {
            if (double.TryParse(txtNumber1.Text, out double num1) &&
                double.TryParse(txtNumber2.Text, out double num2))
            {
                double result = 0;
                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero");
                            return;
                        }
                        result = num1 / num2; break;
                }

                string entry = $"{num1} {op} {num2} = {result}";
                history.Add(entry);
                MessageBox.Show(entry, "Result");
            }
            else
            {
                MessageBox.Show("Please enter valid numbers");
            }
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            HistoryForm hf = new HistoryForm(history);
            hf.Show();
        }
    }
}
