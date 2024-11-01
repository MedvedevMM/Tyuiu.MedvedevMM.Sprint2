using Tyuiu.MedvedevMM.Sprint2.Task3.V4.Lib;
namespace Tyuiu.MedvedevMM.Sprint2.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 11;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.083;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = -4;
            double res = ds.Calculate(x);
            double wait = 0.004;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -9;
            double res = ds.Calculate(x);
            double wait = -98.889;
            Assert.AreEqual(wait, res);
        }
    }
    
}