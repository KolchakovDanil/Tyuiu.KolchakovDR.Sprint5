using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint5.Task2.V14.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint5.Task2.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            TaskHG thg = new TaskHG(
            5,
            "Колчаков Д. Р.",
            "ИИПб-23-2",
            "Класс File. Запись структурированных данных в текстовый файл",
            2,
            14,
            "Дан двумерный целочисленный массив 3 на 3 элементов, заполненный значениями с клавиатуры. Заменить положительные элементы массива на 1, отрицательные на 0. Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.");

            thg.printHeader();

            int[,] matrix = new int[3, 3];
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Элемент массива [{i + 1},{j + 1}]: ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            thg.printFooter();

            string res = ds.SaveToFileTextData(matrix);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан =D");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        matrix[i, j] = 0;
                    }
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                }
            }
            Console.WriteLine();

            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
