using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint5.Task6.V8.Lib;
using TaskHeaderGenerator;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task6.V8
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
            "Обработка текстовых файлов",
            6,
            8,
            "Дан файл С:/DataSprint5/InPutDataFileTask6V8.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:/DataSprint5/ и скопировать в неё файл) в котором есть набор символьных данных. Найти количество слов длиной два символа в заданной строке.");

            thg.printHeader();

            string path = @"C:\DataSprint5\InPutDataFileTask6V8.txt";

            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] ar = line.Split(' ');
                    foreach (var word in ar)
                    {
                        if (word.Length == 2)
                        {
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine("Исходный набор символьных данных в файле: " + path);

            thg.printFooter();
            Console.WriteLine(count);

            Console.ReadKey();
        }
    }
}
