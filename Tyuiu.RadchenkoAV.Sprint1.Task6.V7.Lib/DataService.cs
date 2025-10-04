using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.RadchenkoAV.Sprint1.Task6.V7.Lib
{
    public class DataService : ISprint1Task6V7
    {
        public string DeleteLastLetter(string value)
        {
            value = value.Replace(" ", "");
            value = value.Replace("*", "");
            return value; 

        }
    }
}
