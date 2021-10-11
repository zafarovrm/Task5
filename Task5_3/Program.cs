using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    class Program
    {
        //Метод сортирует первые 5 элементов по возрастанию, вторые 5 – по убыванию.
        static void Main(string[] args)
        {
            const int n = 10;
            int[] array = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < n - 6; i++)
            {
                for (int j = i + 1; j < n - 5; j++)
                {
                    if (array[i] > array[j])
                    {
                        int t = array[i];
                        array[i] = array[j];
                        array[j] = t;
                    }
                }
            }
            for (int i = 5; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int p = array[i];
                        array[i] = array[j];
                        array[j] = p;
                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
