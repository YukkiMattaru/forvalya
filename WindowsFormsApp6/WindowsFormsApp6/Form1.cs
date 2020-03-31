using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{ 

    enum Action
{
    None,
    Sum,
    umn,
    del,
    min,
    sqrt,
}

    public partial class Form1 : Form
    {
        
            Calculator calc = new Calculator();
            double firstNumber = 0;
            double secondNumber = 0;
            Action action = Action.None;
            public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            action = Action.Sum;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            action = Action.del;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox1.Text);
            textBox1.Clear();
            action = Action.min;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox1.Text);
            action = Action.umn;
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToInt32(textBox1.Text);
            //textBox1.Text = Convert.ToString(kulkulytor(firstNumber, sum, secondNumber));
            textBox1.Text = Convert.ToString(calc.kulkulytor(firstNumber, action, secondNumber));
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToInt32(textBox1.Text);
            action = Action.sqrt;
            textBox1.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            textBox1.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button18_Click(object sender, EventArgs e)
        {
            int now = Convert.ToInt32(textBox1.Text);
            now = now / 10;
            textBox1.Text = Convert.ToString(now);
        }
    }
}
