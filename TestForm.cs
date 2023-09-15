using System;
using System.Windows.Forms;

namespace VS_VCS_Prac
{
    public partial class TestForm : Form
    {
        String ArithOp;
        public TestForm()
        {
            ArithOp = "";
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // main functionality
            bool errorFlag=false;
            string result="";
            float numericResult=0.0f;
            float num1= float.Parse(textBox1.Text);
            float num2 = float.Parse(textBox2.Text);
            switch (this.ArithOp)
            {
                case "+":
                    numericResult = num1 + num2;
                    break;
                case "-":
                    numericResult = num1 - num2;
                    break;
                case "*":
                    numericResult = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        numericResult = num1 / num2;
                    }
                    else
                    {
                        errorFlag = true;
                        result = "Division by zero is not allowed.";
                    }
                    break;
            }
            if (!errorFlag)
            {
                result=numericResult.ToString();
            }
            MessageBox.Show(result);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.ArithOp = "+";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                this.ArithOp = "-";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                this.ArithOp = "*";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                this.ArithOp = "/";
            }
        }


    }
}
