using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint5.Task5.V28.Lib;
using TaskHeaderGenerator;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task5.V28
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
            "Чтение набора данных из текстового файла",
            5,
            28,
            "Дан файл С:/DataSprint5/InPutDataFileTask5V28.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и скопировать в неё файл) в котором есть набор значений.Найти факториал наименьшего положительного целого числа, которое делится на 5, в файле.  Полученный результат вывести на консоль.");

            thg.printHeader();

            string path = @"C:\DataSprint5\InPutDataFileTask5V28.txt";
            string strX = File.ReadAllText(path);
            double min = int.MaxValue;
            double res = 1;
            string line;
            using (StreamReader sr = new StreamReader(path))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    double x = Convert.ToDouble(line);
                    if (x < min && x % 5 == 0 && x > 0)
                    {
                        min = x;
                    }
                }
            }
            for (int i = 1; i <= min; i++)
                res *= i;

            Console.WriteLine("Исходный набор данных в файле: " + path);
            Console.WriteLine("Х = " + min);

            thg.printFooter();
            
            Console.WriteLine("Факториал !"+ min + " = " + res);
            Console.ReadLine();
            }
        }
    }

