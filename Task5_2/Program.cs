using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    class Program
    {
        //Метод находит сумму максимального и минимального элементов массива.
        static void Main(string[] args)
        {
            const int n = 15;
            int S = 0;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int max = array[0];
            foreach (int a in array)
            {
                if (a > max)
                    max = a;
            }
            int min = array[0];
            foreach (int b in array)
            {
                if (b < min)
                    min = b;
            }
            Console.WriteLine();
            Console.WriteLine("Максимальное чило {0}", max);
            Console.WriteLine("Минимальное чило {0}", min);
            S = max + min;
            Console.Write("Сумма чисел равна {0} ", S);
            Console.ReadKey();
        }
    }
}
