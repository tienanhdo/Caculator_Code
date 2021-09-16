using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc_Mini
{
    public partial class Form1 : Form
    {
        Double ResultValue = 0; //Hiện thị kết quả tính toán
        String OperationPerformed = ""; //Các phép toán cộng trừ nhân chia
        bool IsOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (IsOperationPerformed))
                textBox1.Clear();

            IsOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if(!textBox1 .Text .Contains ("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }else
            textBox1.Text = textBox1.Text + button.Text;
        }

        private void tinhtoan_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (ResultValue != 0)
            {
                button16.PerformClick();
            }
            OperationPerformed = button.Text;
            ResultValue = Double.Parse(textBox1.Text);
            label_HienThi.Text = ResultValue + " " + OperationPerformed;
            IsOperationPerformed = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            ResultValue = 0;
            label_HienThi.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            switch (OperationPerformed)
            {
                case "+":
                    textBox1.Text = (ResultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (ResultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (ResultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (ResultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default :
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //private void tinhtoan_Click(object sender, EventArgs e)
        //{

        //}
    }
}
