using Tyuiu.MedvedevMM.Sprint2.Task6.V11.Lib;
namespace Tyuiu.MedvedevMM.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new();
            int g = 2024, m = 11, n = 2;

            Assert.AreEqual("03.11.2024", ds.FindDateOfNextDay(g, m, n));
        }
    }
}