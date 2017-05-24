using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ControllerAndModule;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        { 
            string path = "fdsffd";
            Assert.AreEqual(Controller.ProcessFilePath(path), path);
           
        }
        [TestMethod]
        public void TestMethods2()
        {
            string path = null;
            var reader= new Reader();
            var writer = new Writer();
            Assert.AreEqual(reader.SuccesResult(path), null);
            Assert.AreEqual(writer.SuccesResult(path), null);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string path = "c:/work/1.txt";
            string path1 = "c:/work/2.txt";
            var reader = new Reader();
            var writer = new Writer();
            var fileRead = new FileStream(path, FileMode.Open);
            fileRead.Close();
            Assert.AreEqual(reader.SuccesResult(path).GetType(), fileRead.GetType());
            var fileWrite = new FileStream(path1, FileMode.Create);
            fileWrite.Close();
            Assert.AreEqual(writer.SuccesResult(path1).GetType(), fileWrite.GetType());
        }
        [TestMethod]
        public void TestMethod4()
        {
            string path = "c:/work/13.txt";
            var  s = new FileStream(path, FileMode.Open);
            var read = new StreamReader(s);
            string text = read.ReadToEnd();
            Assert.AreEqual(Controller.ProcessText(s).GetType(),text.GetType());
        }
    }
}
