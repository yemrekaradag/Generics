using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 200;
            Console.WriteLine($"num1: {num1}\nnum2: {num2}");
            Swap<int>(ref num1, ref num2);
            Console.WriteLine($"new num1: {num1}\nnew num2: {num2}");

            string str1 = "Yunus";
            string str2 = "Emre";
            Console.WriteLine($"str1: {str1}\nstr2: {str2}");
            Swap<string>(ref str1, ref str2);
            Console.WriteLine($"new str1: {str1}\nnew str2: {str2}");
            Console.ReadLine();
        }
        static void Swap<T>(ref T val1, ref T val2)
        {
            T temp;
            temp = val1;
            val1 = val2;
            val2 = temp;
        }
    }
}
