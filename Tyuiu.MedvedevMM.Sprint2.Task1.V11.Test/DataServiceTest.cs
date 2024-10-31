using System.Reflection;
using Tyuiu.MedvedevMM.Sprint2.Task1.V11.Lib;
namespace Tyuiu.MedvedevMM.Sprint2.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int a = 145;
            int b = 156;
            int c = 142;
            int d = 117;
            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);
            bool[] wait = new bool[6] {false, false, true, false, true, false};

            CollectionAssert.AreEqual(wait, res);

        }
    }
}