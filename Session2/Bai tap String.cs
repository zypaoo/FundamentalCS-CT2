﻿using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_String
    {
        private static void Main10(string[] args)
        {
            /* baitap1();
             baitap2();
             baitap3();
             baitap4();
             baitap5();
             baitap6();*/
            baitap11();

        }
        static void baitap1()
        {
            Console.Write("Input the string: ");
            string s = Console.ReadLine();
            Console.WriteLine("The string you entered is:" + s);
        }
        static void baitap2()
        {
            Console.Write("Input the string: ");
            string s = Console.ReadLine();
            Console.WriteLine("The string you entered is:" + s.Length);
        }
        static void baitap3()
        {
            Console.Write("Input the string: ");
            string s = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                Console.Write(s[i] + " ");
            }
        }
        static void baitap4()
        {
            Console.Write("Input the string: ");
            string s = Console.ReadLine();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                Console.Write(s[i] + " ");
            }
        }
        static void baitap5()
        {
            Console.Write("Input the string: ");
            string s = Console.ReadLine();
            int answer = 1;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    answer += 1;
                }

            }
            Console.WriteLine("Total number of words in the string is:" + answer);
        }
        static void baitap6()
        {
            Console.Write("Input the 1st string: ");
            string s1 = Console.ReadLine();
            Console.Write("Input the 2nd string: ");
            string s2 = Console.ReadLine();
            int check = 0;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i] != s2[i])
                {
                    check++;
                    break;
                }
            }
            if (s1.Length == s2.Length)
            {
                if (check == 0)
                {
                    Console.WriteLine("The length of both strings are equal and also, both strings are equal.");
                }
                else
                {
                    Console.WriteLine("The length of both strings are equal but the strings are not equal.");
                }
            }
            else
            {
                Console.WriteLine("The length of both strings are not equal.");
            }
        }
        static void baitap7()
        {
            Console.Write(" Input the string: ");
            string s = Convert.ToString(Console.ReadLine());
            s = s.ToLower();
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 'a' && s[i] <= 'z')
                {
                    a++;
                }
                else if (s[i] >= '0' && s[i] <= '9')
                {
                    b++;
                }
                else
                {
                    c++;
                }
            }
            Console.WriteLine("Number of Alphabets in the string is : " + a);
            Console.WriteLine("Number of Digits in the string is: " + b);
            Console.WriteLine("Number of Special characters in the string is: " + c);
        }
        static void baitap10()
        {
            Console.WriteLine("Enter a string: ");
            string s = Console.ReadLine();
            char maxChar = ' ';
            int maxCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        count++;
                    }
                }
                if (count > maxCount)
                {

                    maxCount = count;
                    maxChar = s[i];
                }
            }
            Console.WriteLine($"The Highest frequency of character '{maxChar}' appears number of times: {maxCount}");

        }
        static void baitap11()
        {
            int[] a = new int[4];
            bool check;
            do
            {
                do
                {

                    Random rnd = new Random();
                    int comp_num = rnd.Next(1000, 9999);
                    khiem(a, comp_num);
                    check = true;
                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = i + 1; j <= 3; j++)
                        {
                            if (a[i] == a[j])
                            {
                                check = false;
                                break;
                            }
                        }
                    }
                }
                while (check == false);
                Console.WriteLine();
                for (int h = 0; h < 10; h++)
                {
                    Console.Write("Nhap vao mot so co 4 chu so khac nhau i: ");
                    int so = int.Parse(Console.ReadLine());
                    int[] b = new int[4];
                    int countcorrect = 0;
                    int countposition = 0;
                    khiem(b, so);
                    for (int i = 0; i < 4; i++)
                    {
                        if (a[i] == b[i])
                        {
                            countposition++;
                        }
                        for (int j = 0; j < 4; j++)
                        {
                            if (a[i] == b[j])
                            {
                                countcorrect++;
                            }
                        }
                    }

                    if (countcorrect == 4 && countposition == 4)
                    {
                        Console.WriteLine("hay z tr");
                        break;
                    }
                    if (h == 9 && countposition != 4 && countcorrect != 4)
                    {
                        Console.Write("ga v troi, so do la: ");
                        for (int c = 0; c < 4; c++)
                        {
                            Console.Write(a[c]);                          
                        }
                        Console.WriteLine();
                        break;
                    }
                    Console.WriteLine($"{countcorrect} correct number, {countposition} correct position");
                }
                    Console.Write("Ban co muon choi tiep hok? <Y/N>: ");
                    string res = Console.ReadLine();
                    if (res.ToUpper() == "N")
                    {
                        Console.WriteLine("hok choi thi thoi,bai bai");
                        break;
                    }
                
            }
            while (true);
            Console.ReadKey();


            static void khiem(int[] a, int comp_num)
            {
                int n = 3;
                while (n >= 0)
                {
                    a[n] = comp_num % 10;
                    comp_num /= 10;
                    n--;
                }
            }
        }
    }
}
