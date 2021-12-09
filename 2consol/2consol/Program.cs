using System;

namespace _2consol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exep=false;
            try
            { 
                int indMax = 0, indMin = 0;
                int[] myArray = Input();
                double summ = 0;
                for (int i = 0; i < myArray.Length; i++)
                {
                    if (myArray[i] < myArray[indMin])
                        indMin = i;
                    if (myArray[i] > myArray[indMax])
                        indMax = i;
                }
                Console.Write($"\n\tMax:{indMax + 1} min:{indMin + 1}");
                if (indMax < indMin)
                {
                    summ = Summ(myArray, indMax, indMin);
                    Console.Write($"\n\tСумма элементов между максимальным и минимальными элементами(включительно): {summ}");
                }

                if (indMax > indMin)
                {
                    exep=   true;
                    throw new Exception("Сначала максимальное значение должно быть");
                }
            }
            catch (Exception e) when (exep)
            {
                Console.Write($"\n\t ****Ошибка****\n\t\t {e} ");
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
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\t a[{i + 1}]= ");
                a[i] = int.Parse(Console.ReadLine());
            }
            return a;
        }

        static double Summ(int[] a, int startN, int stopN)
        {
            double sum = 0;
            for (int i = startN; i <= stopN; i++)
            {
                if (a[i] > 0) sum += a[i];
             }
            return sum;
        }
    }
}
