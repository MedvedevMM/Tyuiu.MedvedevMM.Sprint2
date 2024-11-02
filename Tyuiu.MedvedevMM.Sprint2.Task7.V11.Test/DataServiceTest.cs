using Tyuiu.MedvedevMM.Sprint2.Task7.V11.Lib;
namespace Tyuiu.MedvedevMM.Sprint2.Task7.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = -0.5;

            bool res = ds.CheckDotInShadedArea(x, y);

            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}