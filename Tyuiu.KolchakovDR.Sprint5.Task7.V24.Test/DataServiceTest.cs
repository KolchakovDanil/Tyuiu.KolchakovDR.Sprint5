using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KolchakovDR.Sprint5.Task7.V24.Lib;
using System.IO;

namespace Tyuiu.KolchakovDR.Sprint5.Task7.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFileOutPut()
        {
            string path = @"C:\Users\d4six\source\repos\Tyuiu.KolchakovDR.Sprint5\Tyuiu.KolchakovDR.Sprint5.Task7.V24\bin\Debug\OutPutDataFileTask7V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
        [TestMethod]
        public void CheckedExistsFileInPut()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask7V24.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
