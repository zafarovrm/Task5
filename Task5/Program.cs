using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        //Метод находит среднее арифметическое элементов
        static void Main(string[] args)
        {
            #region Исходные данные
            Console.WriteLine("Введите 1-е число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 2-е число");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 3-е число");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 4-е число");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 5-е число");
            int e = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 6-е число");
            int f = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите 7-е число");
            int g = Convert.ToInt32(Console.ReadLine());
            #endregion
            const int n = 7;
            float S = 0;
            int[] array = new int[n] { a, b, c, d, e, f, g };
            for (int i = 0; i < n; i++)
            {
                S += array[i];
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            Console.WriteLine("{0:f2} ", S / n);
            Console.ReadKey();
        }
    }
}
