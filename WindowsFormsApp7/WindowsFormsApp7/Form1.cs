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
        int n;
        int max;
        int min;
        int ran;
        int m;
        int[] ar;
        int[,] bar;

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
                    bar[i, j] = rd.Next(10, 100);
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
            int chan2 = 0;
            int po = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < ar.Length; j++)
                {
                    
                    if (ar[j] > ar[min])
                    {
                        min = j;
                    }
                }
                int t = ar[min];
                ar[min] = ar[i]; ;
                ar[i] = t;
            }
            for (int ker = 0; ker < n; ker++)
            {
                for (int j = 0; j < m; j++)
                {
                   textBox7.Text= textBox7.Text + Convert.ToString(ar[ker * m + j]) + Convert.ToString(" ");
                }
               textBox7.AppendText("\r\n");
                
            }
         
            max = bar[0,0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (max < bar[i, j])
                        max = bar[i, j];
                }
            }

            min = bar[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (min > bar[i, j])
                        min = bar[i, j];
                }
            }

            ran = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ran = ran + bar[i, j];
                }
            }
            ran = ran / (n*m);
            textBox3.Text = Convert.ToString(max);
            textBox4.Text = Convert.ToString(min);
            textBox5.Text = Convert.ToString(ran);
        }
            else
            {
                MessageBox.Show("Введите число!!!");
                textBox1.Clear();
                textBox2.Clear();
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
    }
}
