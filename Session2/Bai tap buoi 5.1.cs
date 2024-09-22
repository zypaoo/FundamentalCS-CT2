using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_buoi_5
    {
        public static void Main8(string[] args)
        {
            int[] a = new int[100];
            InputRandomData(a);
            //PrintArray(a);
            //CalculateAvg(a);
            //Console.Write("The value you want to check: ");
            //int val = int.Parse(Console.ReadLine());
            //if (!CheckExist(a,val))
            //    Console.WriteLine("No Exist");
            //else Console.WriteLine(" Exist");
            //if (FindIndex(a, val) > 0)
            //    Console.WriteLine("Position: "+ FindIndex(a, val));
            //Console.Write("Enter a number u wanna remove: ");
            //int ele = int.Parse(Console.ReadLine());
            //PrintArray(a);
            //MaxMin(a);
            //Reserve(a);
            //FindDupe(a);
            //int index = 0;
            int[] c = new int[100];
            PrintArray(a);
            RemoveDupe(a,c);

        }
        static void InputRandomData(int[] a)
        {
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(100);
            }
        }
        static void PrintArray(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void CalculateAvg(int[] a)
        {
            double s = 0;
            foreach (int i in a)
            {
                s += i;
            }
            Console.WriteLine($"The average value of array: {s / a.Length} ");
        }
        static bool CheckExist(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (val == a[i])
                {
                    return true;
                }
            }
            return false;
        }
        static int FindIndex(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == val)
                {
                    return i;
                }
            }
            return -1;
        }
        static void RemoveEle(ref int[] a, int ele)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == ele)
                {
                    for (int j = i; j < a.Length - 1; j++)
                    {
                        a[j] = a[j + 1];
                       
                    }                    
                    Array.Resize(ref a, a.Length-1);
                    i--; 
                }
            }

        }
        static void MaxMin(int[] a)
        {
            int min = a[0];
            int max = a[0];
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                    min = a[i];
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine($"Max: {max}, Min: {min}");
        }
        static void Reserve(int[] a)
        {
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
        }
        static void FindDupe(int[] a,ref int[] c)
        {
            Array.Sort(a);
            int index = 0;
            Console.Write("The duplicate values: ");
            bool[] CheckPrint = new bool[100];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {

                    if (a[j] == a[i])
                    {
                        
                        if (!CheckPrint[a[i]])
                        {
                            c[index] = a[i];
                            index++;
                            CheckPrint[a[i]] = true;
                        }
                        break;
                    }
                }
            }
            Array.Resize( ref c, index);    
            PrintArray(c);
        }
        static void RemoveDupe(int[] a, int[] c)
        {
            FindDupe(a,ref c);
            for (int i = 0; i < c.Length; i++)
            {
                RemoveEle(ref a,c[i]);
            }           
            PrintArray(a);
        }
       

    }
}

