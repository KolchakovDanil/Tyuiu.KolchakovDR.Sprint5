using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint5.Task4.V12.Lib;
using TaskHeaderGenerator;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task4.V12
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
            "Чтение данных из текстового файла",
            4,
            12,
            "Дан файл С:/DataSprint5/InPutDataFileTask4V0.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и скопировать в неё файл) в котором есть вещественное значение. Прочитать значение из файла и подставить вместо Х в формулу. Вычислить значение по формуле (Полученное значение округлить до трёх знаков после запятой) и вернуть полученный результат на консоль.");

            thg.printHeader();

            Console.WriteLine("Формула: у = Cos(x^3) + x/2 ");

            
            string path = @"C:\DataSprint5\InPutDataFileTask4V12.txt";
            string strX = File.ReadAllText(path);
            Console.WriteLine("Исходные данные Х в файле: " + path);
            Console.WriteLine("Х = " + strX);
            thg.printFooter();

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
