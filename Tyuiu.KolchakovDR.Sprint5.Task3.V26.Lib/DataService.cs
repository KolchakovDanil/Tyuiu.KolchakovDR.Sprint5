using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            double res = 0.7 * Math.Pow(x, 3) + 1.52 * Math.Pow(x, 2);
            res = Math.Round(res, 3);

            using (BinaryWriter wrt = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                wrt.Write(BitConverter.GetBytes(res));
            }
            return path;
        }
    }
}
