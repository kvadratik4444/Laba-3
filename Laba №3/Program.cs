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
            int x, i;
            var rand = new Random();
            int ans = rand.Next(1, 11);
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
            int sum = 0, SumSquare = 0;
            int N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i <= N; i++)
            {
                sum += i;
                SumSquare += i * i;
                if (SumSquare > 500) break;
            }
            Console.WriteLine(sum);
            Console.WriteLine(SumSquare);
        }
        private static void F3()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Максимальное кол-во подтягиваний в группе {N * 16}");
            Console.WriteLine($"Минимальное кол-во подтягиваний в группе {N * 12}");
        }
        private static void F4()
        {
            double A = Convert.ToDouble(Console.ReadLine());
            double B = Convert.ToDouble(Console.ReadLine());
            double C = Convert.ToDouble(Console.ReadLine());
            double D = Convert.ToDouble(Console.ReadLine());
            double sum = 0, y, AverageY = 0;
            for (int x = 1;x <= 10; x++)
            {
                y = A * Math.Sqrt(B * x + D) - C * x;
                if (y > 0) sum += y;
                AverageY += y;
            }
            Console.WriteLine(sum);
            Console.WriteLine(AverageY/10);
        }
        private static void F5()
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[N];
            for (int i = 0; i < N; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
            int MaxEl = arr[0], MaxI = 0;
            for (int i = 1; i < N; i++)
            {
                if (arr[i] >= MaxEl)
                { 
                    MaxEl = arr[i];
                    MaxI = i;
                }
            }
            Console.WriteLine(MaxEl);
            Console.WriteLine(MaxI);
        }
        private static void F6()
        {
            double R = Convert.ToDouble(Console.ReadLine());
            int ans = 0;
            for (int i = 0; i < 3; i++) 
            { 
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                if (R * R * 4 >= x * x + y * y) ans++;
            }
            Console.WriteLine(ans);
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
                case 6:
                    F6(); break;
            }
        }
    }
}
