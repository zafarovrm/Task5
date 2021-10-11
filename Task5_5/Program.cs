using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    //Метод формирует двумерный массив размера NxN 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            Random random = new Random();            
            for (int i = 0; i < N; i++)
            {               
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = (i + j) % 2 == 1 ? 0 : 1;
                    Console.Write("{0} ", array[i, j]);                                           
                }
                Console.WriteLine();
            }           
            Console.ReadKey();
        }        
    }
}
