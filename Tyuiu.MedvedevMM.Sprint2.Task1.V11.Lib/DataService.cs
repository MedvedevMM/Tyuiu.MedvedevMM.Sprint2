using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedvedevMM.Sprint2.Task1.V11.Lib
{
    public class DataService : ISprint2Task1V11
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            res[0] = (a == b) | (c == d);
            res[1] = (a + 11 != b) & (c - 25 != d);
            res[2] = (a < b) || (c < d) ;
            res[3] = (a > b) && (c - 26 > d);
            res[4] = !res[0];
            res[5] = (a + 12 >= b) ^ (c >= d);
          
            return res;
        }
    }
}
