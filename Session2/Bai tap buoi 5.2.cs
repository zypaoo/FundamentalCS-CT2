using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_buoi_52
    {
        public static void Main(string[] args)
        {
            //int[] a = new int[10];
            //InputData(a);
            //PrintArray(a);
            //Console.WriteLine();
            //Sort(a);
            Console.Write("Enter a sentence: ");
            string sentence = Console.ReadLine();
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();
            if(!SearchLinear(sentence, word))
                Console.WriteLine("The word don't exist in sentence");
            else
                Console.WriteLine("The word exist in sentence");


        }
        static void InputData(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Please enter a number {i + 1} ");
                bool res = int.TryParse(Console.ReadLine(), out a[i]);
                if (!res)
                {
                    Console.WriteLine("Incorrect, enter again");
                    i--;
                }
            }
        }
        static void PrintArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void Sort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int c = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = c;

                    }
                }
            }
            PrintArray(a);
        }
        static bool  SearchLinear(string sentence, string word)
        {
            char[] s = sentence.ToCharArray();
            char[] w = word.ToCharArray();
            for (int i = 0; i <= s.Length - w.Length; i++)
            {
                bool find = true;
                for (int j = 0; j < w.Length; j++)
                {
                    if (s[i + j] != w[j] && char.ToLower(s[i + j]) != char.ToLower(w[j]))
                    {
                        find = false;
                        break;
                    }
                    if (find)
                    {
                        return true;
                    }

                }
            }
            return false;
        }

    }
}
