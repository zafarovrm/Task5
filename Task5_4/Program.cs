using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    //Метод Определяет количество нечетных положительных элементов, стоящих на четных местах.
    class Program
    {
        static void Main(string[] args)
        {
            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            int count = 0;
            for (int i = 1; i < n; i += 2)
            {
                if (array[i] > 0 && array[i] % 2 == 1)
                {
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}

