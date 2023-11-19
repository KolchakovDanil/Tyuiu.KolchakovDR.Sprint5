using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint5.Task3.V26.Lib;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task3.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            string path = @"C:\Users\d4six\source\repos\Tyuiu.KolchakovDR.Sprint5\Tyuiu.KolchakovDR.Sprint5.Task3.V26\bin\Debug\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
