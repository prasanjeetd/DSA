using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.TakeUForward
{
    public class Paterrn
    {
        public void Test()
        {
            Print1();
            Print2();
            Print3();
            Print4();
            Print5();
            Print6();
            Print7();
            Print8();
        }

        public void Print1()
        {
            //***
            //***
            //***

            var n = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }

        public void Print2()
        {
            //*
            //**
            //***

            var n = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }

        public void Print3()
        {
            //1
            //1 2
            //1 2 3

            var n = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }

        public void Print4()
        {
            //1
            //2 2
            //3 3 3

            var n = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + 1 + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }

        public void Print5()
        {
            //***
            //**
            //*

            var n = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }

        public void Print6()
        {
            //1 2 3
            //1 2
            //1

            var n = 3;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

        }

        public void Print7()
        {
            //  *
            // ***
            //*****

            var n = 6;

            for (int i = 0; i < n; i++)
            {

                int spaces = n - i - 1;
                // Print spaces
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(' ');
                }

                // Print stars
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }

                // Print spaces
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(' ');
                }

                Console.WriteLine();

            }


        }

        public void Print8()
        {
            //*****
            // ***
            //  *


            var n = 6;

            for (int i = 0; i < n; i++)
            {
                // Print space
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Print Stars

                // (2*6 =12) - (2*0 =2 + 1)
                // 12 - 3= 9

                var stars = 2 * n - (2 * i + 1);

                for (int j = 0; j < stars; j++)
                {
                    Console.Write("*");
                }

                // Print space
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}
