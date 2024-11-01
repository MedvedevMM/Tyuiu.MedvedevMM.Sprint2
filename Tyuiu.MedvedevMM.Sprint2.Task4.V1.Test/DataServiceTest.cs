using Tyuiu.MedvedevMM.Sprint2.Task4.V1.Lib;
namespace Tyuiu.MedvedevMM.Sprint2.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 10;
            double res = ds.Calculate(x, y);
            double wait = 0.8;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            double res = ds.Calculate(x, y);
            double wait = 1.375;
            Assert.AreEqual(wait, res);
        }
    }
}