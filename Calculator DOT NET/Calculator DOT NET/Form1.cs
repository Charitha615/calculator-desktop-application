using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_DOT_NET
{
    public partial class Form1 : Form
    {

        //Fields

        Double result = 0;
        string operation = string.Empty;
        string fstNum, secNum;
        bool is_operation = false;


        double num1, num2, results;
        char op;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void BtnNum_Click(object sender, EventArgs e)
        {
            //Clear initia 0 value
          /*  if (TxDisplay1.Text == "0" || is_operation)
            {
                TxDisplay1.Clear();
            }

            Button btn = (Button)sender; // create a object for get the button txt value

            if (btn.Text == ".")
            {
                if (!TxDisplay1.Text.Contains("."))
                {
                    TxDisplay1.Text = TxDisplay1 + btn.Text;
                }
            }
            else
            {
                TxDisplay1.Text = TxDisplay1.Text + btn.Text;

            }

            is_operation = false;*/


            Button btn = (Button)sender;



            if (TxDisplay1.Text == "0")
            {
                TxDisplay1.Text = btn.Text;
            }
            else
            {
                TxDisplay1.Text += btn.Text;
            }

        }

        private void TxDisplay1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operation_(object sender, EventArgs e)
        {
         /*   if (result != 0)
            {
                BtnEq.PerformClick();
                Button btn = (Button)sender; // create a object for get the button txt value
                operation = btn.Text;
                result = double.Parse(TxDisplay1.Text);

                TxDisplay2.Text = result + operation;
                is_operation = true;
            }
            else
            {
                Button btn = (Button)sender; // create a object for get the button txt value
                operation = btn.Text;
                result = double.Parse(TxDisplay1.Text);

                TxDisplay2.Text = result + operation;
                is_operation = true;
            }*/

            Button btn = (Button)sender;
            op = btn.Text[0];
            num1 = double.Parse(TxDisplay1.Text);
            TxDisplay1.Text = "0";

        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            TxDisplay1.Text = "0";
            result = 0;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            /* TxDisplay1.Text = "0";
             TxDisplay2.Text= "0";
             result = 0;*/
            TxDisplay1.Text = "0";
        }

        private void BtnEq_Click(object sender, EventArgs e)
        {
            /*switch (operation)
            {
                case "+": TxDisplay1.Text = (result + double.Parse(TxDisplay1.Text)).ToString();
                        break;

                case "-":
                    TxDisplay1.Text = (result - double.Parse(TxDisplay1.Text)).ToString();
                    break;

                case "*":
                    TxDisplay1.Text = (result * double.Parse(TxDisplay1.Text)).ToString();
                    break;

                case "/":
                    TxDisplay1.Text = (result / double.Parse(TxDisplay1.Text)).ToString();
                    break;
            }*/

            num2 = double.Parse(TxDisplay1.Text);

            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    break;
            }

            TxDisplay1.Text = result.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
