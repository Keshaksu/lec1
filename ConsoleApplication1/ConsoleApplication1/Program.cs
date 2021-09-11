using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ispalindrom = true;
            do
            {
                Console.WriteLine("Введите строку для проверки на палиндром");
                var str =  Console.ReadLine();
                for (int first = 0, last = str.Length - 1; first < last; ++first, --last)
                {
                    if (str[first] != str[last])
                    {
                        ispalindrom = false;
                        break;
                    }
                }
                Console.WriteLine(ispalindrom ? "Палиндром" : "Не палиндром");
                Console.WriteLine("Проверить новую строку? Для продолжения нажмите (1)");
                int q = Int32.Parse(Console.ReadLine());
                if (q == 1) ispalindrom = true;
                else ispalindrom = false;
                Console.Clear();
              }
            while (ispalindrom == true);

            Console.ReadLine();
        }
    }
}
