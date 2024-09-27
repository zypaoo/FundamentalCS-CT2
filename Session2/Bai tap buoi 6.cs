using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_buoi_6
    {
        public static void Mainaaa(string[] args)
        {
            string[][][] a = new string[3][][];
            InputData(a);


            
            
                    
        }
        static void InputData(string[][][] a)
        {
            a[0] = new string[5][];
            a[1] = new string[3][];
            a[2] = new string[6][];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Hay nhap du lieu cho nhom {i + 1}: ");
                for(int j = 0; j < a[i].Length; j++)
                {
                    a[i][j] = new string[2];
                    Console.WriteLine($"Thanh vien co ID {i+1}.{j+1}");
                    Console.Write("Ten: ");
                    string name = Console.ReadLine();
                    a[i][j][0] = name;
                    Console.Write("So nhiem vu da hoan thanh: ");
                    string task = Console.ReadLine();
                    a[i][j][1] = task;
                }
            }

        }

    }
}
