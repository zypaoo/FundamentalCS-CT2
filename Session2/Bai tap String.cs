using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2
{
    internal class Bai_tap_String
    {
       private static void Mainm(string[] args)
{



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
    Console.WriteLine("The string you entered is:" + length(s));
}
static int length(string s)
{
    int len = 0;
    foreach(int i in s) { len++; }
    return len;
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
    s = s.Trim();//bo tat ca cac khoang trang dau va cuoi
    int answer = 1;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == ' ')
        {
            answer += 1;
        }

    }
    for (int i=0; i<s.Length; i++)
    {
        if (s[i]==' ' && s[i+1]==' ')
        {
            answer--;
        }
    }
    Console.WriteLine("Total number of words in the strinfgreg is:" + answer);
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
static void baitap9()
{
    Console.Write(" Input the string: ");
    string s = Convert.ToString(Console.ReadLine());
    s = s.ToLower();
    int countvowel = 0;
    int countcons = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (s[i] == 'a' || s[i] == 'e' || s[i] == 'o' || s[i] == 'u' || s[i] == 'i')
        {
            countvowel++;
        }
        else
        {
            countcons++;
        }
    }
    Console.WriteLine("The total number of vowel in the string is: " + countvowel);
    Console.WriteLine("The total number of consonant in the string is : "+ countcons);
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
static bool SearchLinear(string sentence, string word,ref int count)
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
                count++;

                return true;
            }

        }
        
    }
    return false;
}
static void baitap14()
{
    Console.Write(" Input the string: ");
    string s = Convert.ToString(Console.ReadLine());
    Console.Write(" Input the substring to search: ");
    string w = Convert.ToString(Console.ReadLine());
    int count = 0;
    if(SearchLinear(s, w,ref count))
    {
        Console.WriteLine("The substring exists in the string ");
    }
    else
        Console.WriteLine("The substring doesn't exist in the string ");

}
static void baitap18()
{
    Console.Write(" Input a character: ");
    char c = char.Parse(Console.ReadLine());
    if (c >= 'a' && c <= 'z')
        Console.WriteLine("The character is lowercase.");
    else if (c >= 'A' && c <= 'Z')
        Console.WriteLine("The character is uppercase.");
    else Console.WriteLine("This is not a character");

}
static void baitap19()
{

        Console.Write(" Input the original string: ");
        string s = Convert.ToString(Console.ReadLine());
        Console.Write(" Input the string to be searched for: ");
        string w = Convert.ToString(Console.ReadLine());
        int count = 0;
        if (SearchLinear(s, w, ref count))
        {
            Console.WriteLine($"""The string '{w}' occurs {count} times  """);
        }
        else
            Console.WriteLine("The substring doesn't exist in the string ");

}
       
        
    }
}
