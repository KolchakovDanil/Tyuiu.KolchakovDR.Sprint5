using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task5.V28.Lib
{
    public class DataService : ISprint5Task5V28
    {
        public double LoadFromDataFile(string path)
        {
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

            return Math.Round(res, 3);
        }
    }
}
