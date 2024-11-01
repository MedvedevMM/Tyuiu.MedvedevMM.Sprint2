using Tyuiu.MedvedevMM.Sprint2.Task2.V21.Lib;
namespace Tyuiu.MedvedevMM.Sprint2.Task2.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 13;
            int y = 6;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = true;

            Assert.AreEqual(wait, res);
        }
    }
}