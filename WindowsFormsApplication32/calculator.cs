using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication32
{
    public partial class calculator : Form
    {
        Double resultValue = 0;
            string operationPerFormed ="";
            bool isoperationPerFormed = false;

        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isoperationPerFormed)) 
                textBox_Result.Clear();

            isoperationPerFormed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button15.PerformClick();
                operationPerFormed = button.Text;
                labelCurrentOperation.Text = resultValue + " " + operationPerFormed;
                isoperationPerFormed = true;

            }
            else
            {
                operationPerFormed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelCurrentOperation.Text = resultValue + " " + operationPerFormed;
                isoperationPerFormed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            labelCurrentOperation.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operationPerFormed)
            {

                case "+":
                    textBox_Result.Text =( resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                        case "-":
                    textBox_Result.Text =( resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                        case "*":
                    textBox_Result.Text =( resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                        case "/":
                    textBox_Result.Text =( resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
            //requirements
        }

        private void textBox_Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
