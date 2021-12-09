using System;

namespace _1consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("\n\tРабота с одномерным массивом:");
                int[] myArray = Input();
                double sumArray = Summ(myArray);
                Console.Write($"\tСумма элементов массива: {sumArray}\n");

                // двумерный:
                Console.Write("\n\n\tРабота с двумерным массивом:");
                int[,] myArrayDual = InputDual();
                Console.Write("\n\tМассив:\n");
                for(int i = 0; i < myArrayDual.GetLength(0); i++)
                {
                    for(int j =0; j < myArrayDual.GetLength(1); j++)        
                    {
                        Console.Write($"\t{myArrayDual[i,j]}");
                    }
                    Console.WriteLine();
                }
                double sumArrayDual = Summ(myArrayDual);
                Console.Write($"\tСумма элементов двумерного массива: {sumArrayDual}\n");
            }
            catch (Exception)
            {
                Console.Write("\n\t****Ошибка, видимо Вы ввели не число****\n\n");
            }

        }

        static int[] Input()
        {
            Console.Write("\n\t Введите количество элементов массива: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; ++i)
            {
                Console.Write($"\t a[{i + 1}]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }
        static int[,] InputDual()
        {
            Console.Write("\n\t Введите количество строк массива: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("\n\t Введите количество столбцов массива: ");
            int m = int.Parse(Console.ReadLine());
            int[,] a = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"\t a[{i + 1},{j + 1}]= ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return a;
        }
        static double Summ(int[] a)
        {
            bool excep = false;
            try
            {
                double sum = 0;
                Console.Write("\n\t Введите диапазон индексов чисел для определния их суммы (от): ");
                int startN = int.Parse(Console.ReadLine());
                Console.Write("\n\t Введите диапазон индексов чисел для определния их суммы (до): ");
                int stopN = int.Parse(Console.ReadLine());

                if (startN > a.Length || stopN > a.Length || startN < 1)
                {
                    excep = true;
                    throw new Exception("Ошибка при указании диапазона (выход за пределы).");
                }

                for (int i = startN - 1; i < stopN; i++)
                {
                    if (a[i] > 0) sum += a[i];
                }
                return sum;
            }
            catch (Exception e) when (excep)
            {
                Console.Write($"\n\t ****Ошибка****\n\t\t {e} ");
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        static double Summ(int[,] a)
        {
            bool excep = false;
            try
            {
                double sum = 0;
                Console.Write("\n\t Введите диапазон индексов чисел для определния их суммы (от. формат: \"строка, столбец\" пример: \"1,5\"): ");
                string start = Console.ReadLine();
                string[] borderStart = start.Split(",");

                int startN = Convert.ToInt32(borderStart[0]);
                int startM = Convert.ToInt32(borderStart[1]);

                if (startN > a.GetLength(0) || startM > a.GetLength(1) || startN < 1 || startM < 1)
                {
                    excep=true;
                    throw new Exception("Ошибка при указании диапазона начала диапазона индексов (выход за пределы).");
                }

                Console.Write("\n\t Введите диапазон индексов чисел для определния их суммы (до формат: \"строка, столбец\" пример: \"2,6\"): ");
                string stop = Console.ReadLine();
                string[] borderStop = stop.Split(",");

                int stopN = Convert.ToInt32(borderStop[0]);
                int stopM = Convert.ToInt32(borderStop[1]);
                if (stopN > a.GetLength(0) || stopM > a.GetLength(1) || stopN < startN || stopM < startM)
                {
                    excep=true;
                    throw new Exception("Ошибка при указании диапазона конца диапазона индексов (выход за пределы).");
                }

                for (int i = startN - 1; i < stopN; i++)
                {
                    for (int j = startM - 1; j < stopM; j++)
                    {
                        if (a[i, j] > 0) sum += a[i, j];
                    }
                }
                return sum;
            }
            catch (Exception e) when (excep)
            {
                Console.Write($"\n\t ****Ошибка****\n\t\t {e} ");
                return 0;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}