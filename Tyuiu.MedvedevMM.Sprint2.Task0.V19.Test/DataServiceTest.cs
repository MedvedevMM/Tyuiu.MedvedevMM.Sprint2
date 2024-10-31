using Tyuiu.MedvedevMM.Sprint2.Task0.V19.Lib;
namespace Tyuiu.MedvedevMM.Sprint2.Task0.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperation()
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 177;
            bool[] res = new bool[6];
            res = ds.GetCompareOperations(x, y);
            bool[] wait = new bool[6] {true, true, true, true, true, true};

            CollectionAssert.AreEqual(wait, res);
        }
    }
}