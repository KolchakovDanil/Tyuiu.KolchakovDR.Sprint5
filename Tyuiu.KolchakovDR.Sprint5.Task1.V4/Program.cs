using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint5.Task1.V4.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint5.Task1.V4
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
            "Класс File. Запись набора данных в текстовый файл",
            1,
            4,
            "Дана функция (произвести табулирование) f(x) на заданном диапозоне [-5;5] с шагом 1. Произвести проверку деления на ноль. При делении на ноль вернуть значение 0.Результат сохранить в текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.Значения округлить до двух знаков после запятой.");

            thg.printHeader();

            Console.WriteLine("        Cos(x)");
            Console.WriteLine("F(x) = -------- - Cos(x) * 1,3 + 3x");
            Console.WriteLine("        x + 1");
            
            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Стартовое значение = " + startValue);
            Console.WriteLine("Конечное значение = " + stopValue);

            thg.printFooter();

            string res = ds.SaveToFileTextData(startValue, stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан =D");

            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                valueArray[count] = Math.Round((Math.Cos(x) / (x + 1)) - Math.Cos(x) * 1.3 + 3 * x, 2);
                count++;
            } 

            Console.WriteLine("+----------+----------+");
            Console.WriteLine("|    X     |    f(x)  |");
            Console.WriteLine("+----------+----------+");

            for (int i = 0; i <= len - 1; i++)
            {
                Console.WriteLine("|{0,5:d}     | {1,6:f2}   |", startValue, valueArray[i]);
                startValue++;
            }
            Console.WriteLine("+----------+----------+");

            Console.ReadLine();
        }
    }
}
