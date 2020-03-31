using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n = Convert.ToInt32(Console.ReadLine());
            int p = Convert.ToInt32(Console.ReadLine());
            int q = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[p * q];
            int[,] bar = new int[p, q];
            int max = bar[0, 0];
            //float res = 0;
            Random rd = new Random();
            /* for (int i = 0; i < ar.Length; i++)
             {
                 ar[i] = rd.Next(5, 100);
                 Console.WriteLine(ar[i]);
             }
             for (int i = 0; i < ar.Length; i++)
             {
                 res = res + ar[i];
                 if (ar[i] > max)
                     max = ar[i];
             }
             Console.WriteLine();*/
            for (int i = 0; i < bar.GetLength(0); i++)
            {
                for (int j = 0; j < bar.GetLength(1); j++)
                {
                    bar[i, j] = rd.Next(10, 100);
                }
            }


            // int ker = 0;
            /*for (int r = 0; r < q; r++)
            {
                ar[0 + ker] = bar[ker, r];
                ker = ker + 1;
            }*/
            int index = 0;
            for (int i = 0; i < p; i++)
            {
                for (int j = 0; j < q; j++)
                {
                    ar[index] = bar[i, j];
                    index++;
                }//ker = ker + 1;
            }
            for (int i = 0; i < ar.Length - 1; i++)
            {
                for (int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[i] > ar[j])
                    {
                        ar[i] = ar[i] + ar[j];
                        ar[j] = ar[i] - ar[j];
                        ar[i] = ar[i] - ar[j];
                    }
                }
            }



            /*
                for (int i = 0; i < ar.Length; i++)
                {
                    if (ar[i] > max)
                        max = ar[i];
                }
                for (int i = 0; i < bar.GetLength(0); i++)
                {
                    for (int j = 0; j < bar.GetLength(1); j++)
                    {
                        bar[i,j] = ar[i];
                    }
                }*/

            /* for (int i=0;i<ar.Length-1;i++)
              {
                  for (int j=i+1;j<ar.Length;j++)
                  {
                      if (ar[i]>ar[j])
                      {
                          ar[i] = ar[i] + ar[j];
                          ar[j] = ar[i] - ar[j];
                          ar[i] = ar[i] - ar[j];
                      }
                  }
               // Console.WriteLine();
                  Console.WriteLine(ar[i]);
              }*/


        
            for (int ker = 0; ker < p * q; ker++)
            {
                for (int j = 0; j < q; j++)
                {

                    Console.Write(ar[ker ] + " ");
                  
                }
                Console.WriteLine();
            }




            /*int min = bar[0,0];
            for (int i = 0; i < bar.GetLength(0); i++)
            {
                for (int j = 0; j < bar.GetLength(1); j++)

            {res = res + bar[i,j];
                if (bar[i,j] > max)
                    max = bar[i,j];
                    if (bar[i, j] < min)
                        min = bar[i, j];

                }

            }*/

            for (int j = 0; j < p * q - 1; j++)
            {
                for (int j1 = j + 1; j < p * q; j++)
                {

                    if (ar[j] > ar[j1])
                    {
                        int t = ar[j];
                        ar[j] = ar[j1];
                        ar[j1] = t;
                    }


                }
            }

            /* for  (int j = 0; j < bar.GetLength(1) - 1; j++)
             {
                 for (int i = 0; i < bar.GetLength(0); i++)
                 {
                     for (int k = i + 1; k < bar.GetLength(1); k++)

                         if (bar[i, j] > bar[k, j])
                         {
                             int t = bar[i, j];
                             bar[i, j] = bar[k, j];
                             bar[k, j] = t;
                         }
                 }
             }*/


            for (int i = 0; i < bar.GetLength(0); i++)
            {
                for (int j = 0; j < bar.GetLength(1); j++)
                {

                    Console.Write(bar[i, j] + " ");
                }
                Console.WriteLine();
            }
            // Console.WriteLine(max);
            // Console.WriteLine(res / (p * q));
            //Console.WriteLine(min);
            //  Console.WriteLine(ar[n-1]);
            //for (int i = 0; i < ar.Length; i++)
            //  Console.WriteLine(ar[i]);
            //Console.WriteLine( ar.Sum());
            Console.WriteLine();
            // Console.Write(max+ " " + res / n);
            Console.ReadKey();
        }
    }
}

