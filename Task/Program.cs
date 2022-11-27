using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            static int[,] garden = new int[n, n];
            static void Main(string[] args)
            {
                Thread myThread = new Thread(Gardner2);
                myThread.Start();

                for (int i = n - 1; i >= 0; i--)
                {
                    for (int j = n - 1; j >= 0; j--)
                    {
                        if (garden[i, j] == 2)
                            continue;
                        else
                            garden[i, j] = 1;
                        Thread.Sleep(10);
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write(garden[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
            static void Gardner2()
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (garden[i, j] == 1)
                            continue;
                        else
                            garden[i, j] = 2;
                        Thread.Sleep(10);
                    }
                }
            }
    }
}
