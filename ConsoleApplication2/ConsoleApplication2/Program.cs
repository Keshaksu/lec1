using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            String path = @"C:\Users\862-19\Desktop\txt1.txt";
            string[] readText = File.ReadAllLines(path);
            foreach (string s in readText)
            {
                Console.Write(s);
                bool ispalindrom = true;
                for (int first = 0, last = s.Length - 1; first < last; ++first, --last)
                {
                    if (s[first] != s[last])
                    {
                        ispalindrom = false;
                        break;
                    }
                }
                if (ispalindrom)
                    Console.WriteLine(" - Является палиндромом");
                else Console.WriteLine(" - Не является палиндромом");
            }
        }
    }
}
