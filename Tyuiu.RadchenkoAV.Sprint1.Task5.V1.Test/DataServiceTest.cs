using Tyuiu.RadchenkoAV.Sprint1.Task5.V1.Lib;
namespace Tyuiu.RadchenkoAV.Sprint1.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            var ds = new DataService();

            Assert.AreEqual(1, ds.DistanceBetweenDots(1, 1, 2, 2));
        }
    }
}
