using Tyuiu.ArapovTY.Sprint4.Task1.V3.Lib;
namespace Tyuiu.ArapovTY.Sprint4.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 8, 8, 9, 6, 5, 3, 2, 9, 7, 7, 7 };
            int res = ds.Calculate(numsArray);
            int wait = 3072;
            Assert.AreEqual(wait, res);
        }
    }
}