using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1_ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Введите двузначное число:");
            a = Convert.ToInt32(Console.ReadLine());
            if (!(a  > 9 && a < 100))
                Console.WriteLine("Число не двузначное");
            else
            {
                b = a / 10;
                c = a % 10;
                if (b > c) Console.WriteLine("Первая цифра больше.");
                else Console.WriteLine("Вторая цифра больше.");
            }
            Console.ReadKey();
        }
    }
}

