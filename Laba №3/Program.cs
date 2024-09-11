using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__3
{
    internal class Program
    {
        public static void F1()
        {
            int x;
            var rand = new Random();
            int ans = rand.Next(1, 11);
            int i;
            Console.WriteLine("Введите число");
            for (i = 1; ;i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (ans == x) break;
                else if (ans > x) Console.WriteLine("Введенное число меньше загадоного");
                else Console.WriteLine("Введенное число больше загадоного");
            }
            Console.WriteLine($"Вы угадали число, число попыток {i}");
        }
        private static void F2()
        {

        }
        private static void F3()
        {

        }
        private static void F4()
        {

        }
        private static void F5()
        {

        }
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Выберите номер задания");
            x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                case 1:
                    F1(); break;
                case 2:
                    F2(); break;
                case 3:
                    F3(); break;
                case 4:
                    F4(); break;
                case 5:
                    F5(); break;
            }
        }
    }
}
