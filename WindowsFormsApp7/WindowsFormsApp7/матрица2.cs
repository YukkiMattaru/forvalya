using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        int p;
        int k;
        int n;
        int m;
        int[] ar;
        int[,] bar;
        int[,] matrix2;
        int[,] matrixres;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //n = Convert.ToInt32(textBox1.Text);
           // textBox1.BackColor = Color.AliceBlue;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {/*
             m = Convert.ToInt32(textBox2.Text);
            textBox2.BackColor = Color.AliceBlue;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((int.TryParse(textBox1.Text , out n) == true) &&(int.TryParse(textBox2.Text, out m) == true))
            {
            Random rd = new Random();
            bar = new int[n,m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    bar[i, j] = rd.Next(1, 10);
                }
            }

           for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                        textBox6.Text =textBox6.Text + Convert.ToString(bar[i,j]) + Convert.ToString(" ");
                textBox6.AppendText("\r\n");
                }


            ar = new int[m * n];
            int index=0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ar[index] = bar[i, j];
                    index++;
                }
            }
        }
            else
            {
                MessageBox.Show("Введите число!!!");
                textBox1.Clear();
                textBox2.Clear();
            }



            if ((int.TryParse(textBox9.Text, out p) == true) && (int.TryParse(textBox8.Text, out k) == true))
            {
                Random rd = new Random(100);
                matrix2 = new int[p, k];
                for (int i = 0; i < p; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                       matrix2[i, j] = rd.Next(1, 10);
                    }
                }

                for (int i = 0; i < p; i++)
                {
                    for (int j = 0; j < k; j++)
                        textBox7.Text = textBox7.Text + Convert.ToString(matrix2[i, j]) + Convert.ToString(" ");
                    textBox7.AppendText("\r\n");
                }
            }
            else
            {
                MessageBox.Show("Введите число!!!");
                textBox8.Clear();
                textBox9.Clear();
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            matrixres = new int[n, m];
            if ((n==p)&&(m==k))
            {
                for (int i=0;i<n;i++)
                {
                    for (int j=0;j<m;j++)
                    {
                        matrixres[i, j] = bar[i, j] + matrix2[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите другие числа!");
                textBox8.Clear();
                textBox9.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }

            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < k; j++)
                    textBox3.Text = textBox3.Text + Convert.ToString(matrixres[i, j]) + Convert.ToString(" ");
                textBox3.AppendText("\r\n");
            }

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            matrixres = new int[n, m];
            if ((n == p) && (m == k))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrixres[i, j] = bar[i, j] - matrix2[i, j];
                    }
                }
            }
            else
            {
                MessageBox.Show("Введите другие числа!");
                textBox8.Clear();
                textBox9.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }

            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < k; j++)
                    textBox3.Text = textBox3.Text + Convert.ToString(matrixres[i, j]) + Convert.ToString(" ");
                textBox3.AppendText("\r\n");
            }

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
            matrixres = new int[n, m];
            //if ((int.TryParse(textBox4.Text, out p) == true))
            int umn = Convert.ToInt32(textBox4.Text);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixres[i, j] = bar[i, j] * umn;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    textBox3.Text = textBox3.Text + Convert.ToString(matrixres[i, j]) + Convert.ToString(" ");
                textBox3.AppendText("\r\n");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    textBox3.Text = textBox3.Text + Convert.ToString(bar[j, i]) + Convert.ToString(" ");
                textBox3.AppendText("\r\n");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            matrixres = new int[n, m];
            if ((n == k) && (m == p))
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        matrixres[i, j] = bar[i, j] * matrix2[j, i];
                    }
                }
            }
            else
            {
                MessageBox.Show("Умножение не возможно!Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
                textBox8.Clear();
                textBox9.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < k; j++)
                    textBox3.Text = textBox3.Text + Convert.ToString(matrixres[i, j]) + Convert.ToString(" ");
                textBox3.AppendText("\r\n");
            }

        }
    }
}
