using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint5.Task0.V14.Lib;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task0.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\Рамиль\source\repos\Tyuiu.KolchakovDR.Sprint5\Tyuiu.KolchakovDR.Sprint5.Task0.V14\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileI = new FileInfo(path);
            bool fileE = fileI.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileE);
        }
    }
}
