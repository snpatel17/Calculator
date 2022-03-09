using Calculator.Views;
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
    public partial class CalculatorForm : Form, ICalculatorView
    {

        public CalculatorForm()
        {
            InitializeComponent();
        }

        public double NumberOne { get => Double.Parse(txtDisplay.Text); set => txtDisplay.Text=value.ToString(); }
        public double Result { get; set; }
        public string Operator { get; set; }

        public void ShowResult(double result, string newOperator)
        {
            if (newOperator != "=")
            {
                lblShowOperations.Text = result.ToString() + newOperator;
            }
            else
            {
                lblShowOperations.Text = result.ToString();
            }
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {

        }

        private void btnNumberClick(object sender, EventArgs e)
        {
            Button btnInput = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + btnInput.Text;
        }

        public event Func<object, EventArgs, double> ViewEvent;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            Button btnEqual = (Button)sender;

            if (isNoEmpty(txtDisplay))
            {
                ShowResult(ViewEvent(sender, e), btnEqual.Text);
                txtDisplay.Clear();
            }
            Operator = btnEqual.Text;
        }

        private bool isNoEmpty(TextBox txtInput)
        {
            if (!string.IsNullOrEmpty(txtInput.Text))
                return true;
            else
                return false;
        }

    }
}
