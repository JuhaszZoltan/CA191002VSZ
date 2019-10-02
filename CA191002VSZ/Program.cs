using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CA191002VSZ
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            #region 2/1. feladat

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Zoli");
            //}

            #endregion
            #region 2/2. feladat
            //Console.Write("n = ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("szöveg: ");
            //string sz = Console.ReadLine();

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write(sz);
            //    if (i != (n - 1)) Console.Write(" ");
            //}
            #endregion
            #region 2/3. feladat
            //for (int i = 10; i < 0; i--)
            //{
            //    Console.Write(i);
            //    Thread.Sleep(100);
            //    Console.Clear();
            //}
            //Console.WriteLine("viszont látásra!");
            //Thread.Sleep(3000);
            #endregion
            #region 2/4. feladat "A" megoldás
            //string nev = "Juhász Zoltán";
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.Clear();
            //    for (int j = 0; j < i; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write(nev);
            //    Thread.Sleep(200);
            //}
            #endregion
            #region 2/4. feladat "B" megoldás
            //string nev = "Zolikaaaa";
            //for(int i = 0; i < 100; i++)
            //{
            //    int l = rnd.Next(Console.WindowWidth - nev.Length);
            //    int t = rnd.Next(Console.WindowHeight);

            //    Console.SetCursorPosition(l, t);

            //    Console.WriteLine(nev);
            //    Thread.Sleep(500);
            //    Console.Clear();
            //}
            #endregion
            #region 2/5-6. feladat

            Console.CursorVisible = false;

            for(int i = 0; i < 100000; i++)
            {
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight -1));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(16);
                Console.BackgroundColor = (ConsoleColor)rnd.Next(16);
                Console.Write("*");
            }

            #endregion

            Console.ReadKey();
        }
    }
}
