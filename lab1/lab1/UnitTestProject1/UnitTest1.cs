using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Тест на возращение null метода Line.Check ,если прямые паралельны
        [TestMethod]
        public void TestMethod1()
        {
            var c = new Line(1, 1);
            var t = new Line(1, 2);
            Assert.AreEqual(null, Operations.Cross(c, t));
        }
        //Тест на возращение типа point метода Line.Check
        [TestMethod]
        public void TestMethod2()
        {
            var a = new Line(-1, 1);
            var b = new Line(1, 2);
            var c = new point((double)-0.5, (double)1.5);
            Assert.AreEqual(c.GetType(), Operations.Cross(a, b).GetType());

        }

        //Тест на возращение типа point метода Line.Check
        [TestMethod]
        public void TestMethod4()
        {
            var a = new Line(-1, 0);
            var b = new Line(1, 0);
            var c = new point((double)0, (double)0);
            Assert.AreEqual(c.GetType(), Operations.Cross(a, b).GetType());

        }
        //Тест на возращение типа point если прямые одинаковые
        [TestMethod]
        public void TestMethod3()
        {
            var a = new Line(1, 1);
            var b = new Line(1, 1);
            var c = new point(1, 1);
            Assert.AreEqual(c.GetType(), Operations.Cross(a, b).GetType());
        }
    }
}
