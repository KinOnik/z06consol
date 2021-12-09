using System;

namespace _3consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int[,] myArray = Input();
                double summ = 0;
                int sizeArray = myArray.GetLength(0);
                Console.Write("\n\t До изменения:");
                for (int i = 0; i < sizeArray; i++)
                {
                    Console.Write("\n\t");
                    for (int j = 0; j < sizeArray; j++)
                    {
                        Console.Write($" {myArray[i, j]}");
                    }
                }
                teleport(myArray);


                Console.Write("\n\n\t После изменения:");
                for (int i = 0; i < sizeArray; i++)
                {
                    Console.Write("\n\t");
                    for (int j = 0; j < sizeArray; j++)
                    {
                        Console.Write($" {myArray[i, j]}");
                    }
                }

            }
            catch (Exception)
            {
                Console.Write("\n\t****Ошибка, видимо Вы ввели не число****\n\n");
            }

        }

        static int[,] Input()
        {
            Console.Write("\n\t Введите количество элементов массива(NxN): ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"\t a[{i + 1}, {j+1}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }

        static void teleport(int[,] a)
        {
            int sizeArray = a.GetLength(0);
            if (sizeArray % 2 == 0)
            {
                int[] buf = new int[sizeArray];
                for (int i = 0; i < sizeArray; i += 2)
                {
                    for (int j = 0; j < sizeArray; j++)
                    {
                        buf[j] = a[i, j];
                        a[i, j] = a[i + 1, j];
                        a[i + 1, j] = buf[j];
                    }
                }
            }
            else
                Console.WriteLine("\n\t В массиве нечетное количество строк и столбцов - ничего не меняю.");
        }
    }
}
