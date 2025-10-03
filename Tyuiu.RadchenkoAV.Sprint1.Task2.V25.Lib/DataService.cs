using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RadchenkoAV.Sprint1.Task2.V25.Lib
{
    public class DataService : ISprint1Task2V25
    {
        public double ConvertRadsToDegrees(int value)
        {
            double angle =  value * (180 / Math.PI);
            return  Math.Round(angle, 3);
        }
    }
}
