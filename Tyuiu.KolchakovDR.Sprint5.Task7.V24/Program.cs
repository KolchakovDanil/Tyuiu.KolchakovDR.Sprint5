﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KolchakovDR.Sprint5.Task7.V24.Lib;
using TaskHeaderGenerator;
using System.IO;
using System.Text.RegularExpressions;

namespace Tyuiu.KolchakovDR.Sprint5.Task7.V24
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
            "Добавление к решению итоговых проектов по спринту",
            7,
            24,
            "Дан файл С:\\DataSprint5\\InPutDataFileTask7V24.txt (файл взять из архива согласно вашему варианту. Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор символьных данных.Заменить все русские слова на слово \"слово\".Полученный результат сохранить в файл OutPutDataFileTask7V24.txt.");

            thg.printHeader();
            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";

            Console.WriteLine("Данные находяться в файле: " + path);

            thg.printFooter();

            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V24.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            
            string strLine = "";
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    for (int i = 0; i < line.Length; i++)
                    {
                        strLine = Regex.Replace(line, @"\b\p{IsCyrillic}+\b", "слово");
                    }


                    File.AppendAllText(pathSaveFile, strLine + Environment.NewLine);
                    Console.WriteLine("Результат предложения: " + strLine);
                    strLine = "";
                }
            }
            Console.WriteLine();
            Console.WriteLine("Результат находится в файле: " + pathSaveFile);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
