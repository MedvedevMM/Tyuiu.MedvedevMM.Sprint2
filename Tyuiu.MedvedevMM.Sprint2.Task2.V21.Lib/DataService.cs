using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedvedevMM.Sprint2.Task2.V21.Lib
{
    public class DataService : ISprint2Task2V21
    {
        public bool CheckDotInShadedArea(int x, int y)
        {
            bool res;

            if (x == 3 && (y >= 3 & y <= 7)) return true;
            if ((x == 4 || x == 5) && (y >= 6 & y <= 9)) return true;
            if (x == 6 && (y >= 5 && y <= 9)) return true;
            if ((x == 7 || x == 8) && (y >= 5 && y <= 7)) return true;
            if (x == 9 && (y >= 3 && y <= 7 || y >= 11 && y <= 12)) return true;
            if (x == 10 && (y >= 3 && y <= 12)) return true;
            if ((x == 11 || x == 12) && (y >= 3 && y <= 11)) return true;
            if (x == 13 && (y >= 6 && y <= 8)) return true;

            else return false;



        }
    }
}
