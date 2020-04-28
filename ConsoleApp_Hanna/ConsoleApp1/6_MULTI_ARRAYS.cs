using System;
using MAIN_NAM;
using NoughtsCrosses;

namespace MULTI_ARRAYS_NAM
{
    public class MULTI_ARRAYS
    {
        public void MULTI_ARRAYS_M()
        {
            Console.WriteLine("\t\t\tMulti-dimensional arrays & Jagged Array");
            Console.WriteLine("Each element is a massive");
            int[,] nu = new int[10, 10];
            //nu[0, 0] = 11;
            //nu[0, 1] = 12;
            //nu[0, 2] = 13;
            //nu[1, 0] = 21;
            //nu[1, 1] = 22;
            //nu[1, 2] = 23;
            //nu[2, 0] = 31;
            //nu[2, 1] = 32;
            //nu[2, 2] = 33;
            Console.WriteLine(nu[1, 2]);
            for (int i = 0; i < 10; i++)
            {
                for (int jj = 0; jj < 10; jj++)
                {
                    nu[i, jj] = i + jj;
                    Console.Write(nu[i, jj] + " ");
                }
                Console.WriteLine();
            }
            float[] cc = { 1.23f, 2.23f, 3.43f, 8.34f };
            foreach (float el in cc) //without length
            {
                Console.WriteLine(el);
            }
            int[] nums1 = new int[] { 0, 1, 2, 3, 4, 5 };
            int[,] nums2 = { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums11;
            int[,] nums21 = new int[2, 3];
            int[,] nums3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] nums6 = { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,,] nums31 = new int[2, 3, 4];
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            foreach (int i in mas)
                Console.Write($"{i} ");
            Console.WriteLine();
            int[,] mas1 = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            int rows = mas1.GetUpperBound(0) + 1;
            Console.WriteLine("Rows = " + rows);
            //int columns = mas1.Length / rows;
            int columns = mas.GetUpperBound(1) + 1;
            Console.WriteLine("Columns = " + columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas1[i, j]} \t");
                }
                Console.WriteLine();
            }
            int[][,] nums10 = new int[3][,]
            {
                                    new int[,] { {1,2}, {3,4} },
                                    new int[,] { {1,2}, {3,6} },
                                    new int[,] { {1,2}, {3,5}, {8, 13} }
            };
            //зубчатые массивы
            Console.WriteLine("\t\t\tJUGGED ARRAYS");
            Game game = new Game();
            game.PlayGame();
            Console.WriteLine("Game over");

            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numbers)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }
            // перебор с помощью цикла for
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    Console.Write($"{numbers[i][j]} \t");
                }
                Console.WriteLine();
            }
            //Найдем количество положительных чисел в массиве
            Console.WriteLine("Find the nuber of positive numbers in array");
            int[] numbers11 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            int result = 0;
            foreach (int number in numbers11)
            {
                if (number > 0)
                {
                    result++;
                }
            }
            Console.WriteLine($"Number of elements > 0: {result}");
            int[] numbers1 = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
            // инверсия массива, то есть переворот его в обратном порядке
            Console.WriteLine("Inverse sorting of massive");
            int n = numbers1.Length; // длина массива
            int k = n / 2;          // середина массива
            int temp;               // вспомогательный элемент для обмена значениями
            for (int i = 0; i < k; i++)
            {
                temp = numbers1[i];
                numbers1[i] = numbers1[n - i - 1];
                numbers1[n - i - 1] = temp;
            }
            foreach (int i in numbers1)
            {
                Console.Write($"{i} \t");
            }
            Program.CheckReturnToContent();
        }
    }
}
