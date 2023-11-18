using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint5.Task1.V4.Lib;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task1.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\d4six\source\repos\Tyuiu.KolchakovDR.Sprint5\Tyuiu.KolchakovDR.Sprint5.Task1.V4\bin\Debug\OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);  
        }
    }
}
