using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    //Метод формирует двумерный массив размера NxN и определяет, является ли введенная с клавиатуры матрица магическим квадратом. 
    class Program
    {
        static void Main(string[] args)
        {
            #region Исходные данные
            Console.WriteLine("Введите значение N");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            int sum = 0;//Магическая константа  
            int sumRow = 0;//Сумма чисел в строках
            int sumCol = 0;//Сумма чисел в колонках
            int sumDiag1 = 0;//Сумма чисел по диагонали 1
            int sumDiag2 = 0;//Сумма чисел по диагонали 2
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.WriteLine("Введите элемент массива");
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                    sum += array[i, j];
                }
            }
            #endregion
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    sumRow += array[i, j];
                    sumCol += array[j, i];
                }
                sumDiag1 += array[i, i];
                sumDiag2 += array[N - 1 - i, i];
            }
            sum = (N * (N * N + 1)) / 2;        
            if (sumRow/N != sum || sumCol/N != sum || sumDiag1 != sum || sumDiag2 != sum)
            {
                Console.WriteLine("Не является магическим квадратом");
            }
            else
            {
                Console.WriteLine("Является магическим квадратом");
            }
            Console.ReadKey();
        }
    }
}