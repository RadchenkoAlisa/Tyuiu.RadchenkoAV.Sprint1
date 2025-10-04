using Tyuiu.RadchenkoAV.Sprint1.Task6.V7.Lib;
namespace Tyuiu.RadchenkoAV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "1 + 2 + 3";
            DataService ds = new DataService();
            string res = ds.WorkWithText(strTest);
            string wait = "123";
            Assert.AreEqual(wait, res);
        }
    }
}
