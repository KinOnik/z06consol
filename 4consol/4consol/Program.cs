using System;

namespace _4consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[][] myArray = Input();
                int sizeArray = myArray.GetLength(0);
                Console.Write("\n\t Изначальный массив:");
                for (int i = 0; i < sizeArray; i++)
                {
                    Console.Write("\n\t");
                    for (int j = 0; j < sizeArray; j++)
                    {
                        Console.Write($" {myArray[i][j]}");
                    }
                }

                int[] countMore = countingMore(myArray);

                for (int i = 0; i < sizeArray; i++)
                {
                    Console.Write($"\n\t{countMore[i]}");
                }
            }
            catch (Exception)
            {
                Console.Write("\n\t****Ошибка, видимо Вы ввели не число****\n\n");
            }

        }

        static int[][] Input()
        {
            Console.Write("\n\t Введите количество элементов массива(NxN): ");
            int n = int.Parse(Console.ReadLine());
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                a[i] = new int[n];
                for (int j = 0; j < n; j++)
                {

                    Console.Write($"\t a[{i + 1}, {j + 1}]= ");
                    a[i][j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static int[] countingMore(int[][] a)
        {
            try
            {
                int n = a.Length;
                Console.Write("\n\t Введите элемент больше которого нужно посчитать: ");
                int whoMore = int.Parse(Console.ReadLine());
                int[] count = new int[n];
                for (int i = 0; i < n; i++)
                {
                    count[i] = 0;
                    for (int j = 0; j < n; j++)
                    {
                        if (a[i][j] > whoMore)
                            count[i]++;
                    }
                }
                return count;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
