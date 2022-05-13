﻿using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {

            //AddTwoNumbers(20, 6); liitmistehe näidis
            //DivideTwoNumbers(20, 6); jagamistehe näidis

            Console.WriteLine("sisesta esimest arvu");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sisesta teist arvu");
            int userNumberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("vali tehe (sisesta '+' või '/' või '-' või '*')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator)
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                case '*':
                    MultiplyTwoNumbers(userNumberOne, userNumberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void AddTwoNumbers(int x, int y)
        {
            //Console.WriteLine("Hello World!");

            int result = x + y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }


        public static void SubtractTwoNumbers(int x, int y)
        {            

            int result = x - y;
            Console.WriteLine(result);
        }

        public static void MultiplyTwoNumbers(int x, int y)
        {
            int result = x * y;
            Console.WriteLine(result);
        }



    }
}
