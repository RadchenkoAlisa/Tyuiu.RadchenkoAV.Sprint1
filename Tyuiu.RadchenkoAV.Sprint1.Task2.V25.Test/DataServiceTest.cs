using Tyuiu.RadchenkoAV.Sprint1.Task2.V25.Lib;
namespace Tyuiu.RadchenkoAV.Sprint1.Task2.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 4;
            var res = ds.ConvertRadsToDegrees(x);
            Assert.AreEqual(229.183, res);
        }
    }
}
