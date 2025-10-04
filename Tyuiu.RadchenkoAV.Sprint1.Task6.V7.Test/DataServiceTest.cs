using Tyuiu.RadchenkoAV.Sprint1.Task6.V7.Lib;
namespace Tyuiu.RadchenkoAV.Sprint1.Task6.V7.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            string strTest = "hello world";
            DataService ds = new DataService();
            string res = ds.DeleteLastLetter(strTest);
            string wait = "hell worl";
            Assert.AreEqual(wait, res);
        }
    }
}
