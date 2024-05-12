using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TPMOD12_1302223138;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 form = new Form1();

            form.CariTandaBilangan(100);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Form1 form = new Form1();

            form.CariTandaBilangan(-100);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Form1 form = new Form1();

            form.CariTandaBilangan(0);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Form1 form = new Form1();
            string result = form.CariTandaBilangan(-5);
            Assert.AreEqual("Positif", result, "Expected 'Positif' for input -5.");
        }
    }
}