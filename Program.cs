using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OD_arrays_pract3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Задача 1.
                //Заполнить одномерный массив с клавиатуры и вывести его на экран консоли с использованием цикла for.

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Console.Write("Введите элементы массива: \n");
                int i;
                for (i = 0; i < array.Length; i++)
                {
                    Console.Write($"Array[{i}] = ");
                    array[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.Write("\nЭлементы массива: \n");
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array[{i}] = {array[i]}");
                }*/

                //Задача 2.
                //Заполнить одномерный массив случайным образом и вывести его на экран с использованием цикла foreach.

                /*Console.Write("Введите количество элементов массива: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[n];
                Random random = new Random();
                int i;
                Console.WriteLine("\nЭлементы массива:\n");
                for (i = 0; i < array.Length; i++)
                {
                    array[i] = random.Next(-150, 150);
                }
                    foreach (int element in array)
                {
                    Console.Write($"{element}\t");
                }*/


                //Задача 3.
                //В одномерном массиве, заполненном с использованием явной инициализации, найти:
                //1.максимальный элемент и его индекс;
                //2.минимальный элемент и его индекс;
                //3.поменять местами максимальный и минимальный элементы, вывести одномерный массив;
                //4.количество элементов между максимальным и минимальным элементами.

                /*int[] array = { -3, 5, 18, 19, -2, -4, 0, 9 };         //Явная инициализация массива
                int i;
                int max = array[0];           //Поиск максимального значения
                int imax = 0;
                for (i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        imax = i;
                    }
                }
                Console.WriteLine($"Мax: {max} \tIndex: {imax}");

                int min = array[0];           //Поиск минимального значения
                int imin = 0;
                for (i = 1; i < array.Length; i++)
                {
                    if (array[i] < min)
                    {
                        min = array[i];
                        imin = i;
                    }
                }
                Console.WriteLine($"Min: {min} \tIndex: {imin}\n");

                int p = array[imax];                //Меняем местами максимальное и минимальное число
                array[imax] = array[imin];
                array[imin] = p;
                for (i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"Array[{i}] = {array[i]}\tIndex: {i}");
                }

                Console.WriteLine($"Количество элементов между макс. и мин. элементов: {Math.Abs(imax - imin) - 1}\n");   //Поиск количества элементов между значениями
                */

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Исключение: {ex.Message}");
                Console.WriteLine($"Метод: {ex.TargetSite}");
                Console.WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            Console.ReadKey();
        }
    }
}
