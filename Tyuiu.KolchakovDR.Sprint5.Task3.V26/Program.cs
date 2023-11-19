using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint5.Task3.V26.Lib;
using TaskHeaderGenerator;

namespace Tyuiu.KolchakovDR.Sprint5.Task3.V26
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
            "Потоковый метод записи данных в бинарный файл",
            3,
            26,
            "Данное выражение вычислить при его значение x = 2, результат сохранить в бинарный файл OutPutFileTask3.bin и вывести на консоль. Округлить до трёх знаков после запятой.");

            thg.printHeader();

            Console.WriteLine("F(x) = 0.7 * x^3 + 1.52 * x^2");

            int x = 2;
            Console.WriteLine("Данное выражение при х = 2, имеет следующие вид:");
            Console.WriteLine("F(" + x + ") = 0.7 * " + x + "^3 + 1.52 * " + x + "^2");
            
            double res2 = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            res2 = Math.Round(res2, 3);
            Console.WriteLine("Ответ: F(" + x + ") = " + res2);

            thg.printFooter();

            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан =D");



            Console.ReadLine();
        }
    }
}
