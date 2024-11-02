using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.MedvedevMM.Sprint2.Task6.V11.Lib
{
    public class DataService : ISprint2Task6V11
    {
        public string FindDateOfNextDay(int g, int m, int n)
        {
            switch (m)
            {
                case 1: case 3:case 5:case 7:case 8:case 10:case 12: 
                    {
                        if ((n == 31) && (m != 12))
                        {
                            m++;
                            n = 1;
                        }
                        else if ((n == 31) && (m == 12))
                        {
                            g++;
                            m = 1;
                            n = 1;
                        }
                        else
                        {
                            n++;
                        }
                        break;
                    }
                case 4: case 6: case 9: case 11:
                    {
                        if (n == 30)
                        {
                            m++;
                            n = 1;
                        }
                        else
                        {
                            n++;
                        }
                    }   break;  
                case 2:
                    {
                        if (n == 28)
                        {
                            m++;
                            n = 1;
                        }
                        else
                        {
                            n++;
                        }
                    }   break;
                    
                default: return "Неверные данные";
            }
            if ((n / 10 == 0) && (m / 10 == 0)) return ("0" + n + ".0" + m + "." + g);
            else if (m / 10 == 0) return (n + ".0" + m + "." + g);
            else if (n / 10 == 0) return ("0" + n + "." + m + "." + g);
            else return (g + "." + m + "." + n);
        }
        
    }
}
