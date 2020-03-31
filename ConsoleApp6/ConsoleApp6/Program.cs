using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[p * q];
            int[,] bar = new int[p, q];
            // int max = bar[0, 0];
            Random rd = new Random();
            for (int i = 0; i < bar.GetLength(0); i++)
            {
                for (int j = 0; j < bar.GetLength(1); j++)
                {
                    bar[i, j] = rd.Next(10, 100);
                }
            }
            int index = 0;
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    ar[index] = bar[i, j];
                    index++;
                }
            }
            //выбор
            //int oppo = 0;
            int chan2 = 0;
            int po = 0;
            for (int i = 0; i < ar.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < ar.Length; j++)
                {

                    //oppo = ar[i];
                    if (ar[j] > ar[min])
                    {
                        min = j;
                    }
                }
                int t = ar[min];
                ar[min] = ar[i]; ;
                ar[i] = t;

            }
            for (int ker = 0; ker < p; ker++)
            {
                for (int j = 0; j < q; j++)
                {
                    Console.Write(ar[ker * q + j] + " ");
                }
                Console.WriteLine();
            }
            /*for (int i = 0; i < bar.GetLength(0); i++)
            {
                for (int j = 0; j < bar.GetLength(1); j++)
                {
                    Console.Write(bar[i, j] + " ");
                }
              `  Console.WriteLine();
            }*/
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
