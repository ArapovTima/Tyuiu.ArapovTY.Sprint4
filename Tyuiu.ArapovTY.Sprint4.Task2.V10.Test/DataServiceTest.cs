using Tyuiu.ArapovTY.Sprint4.Task2.V10.Lib;
namespace Tyuiu.ArapovTY.Sprint4.Task2.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 2, 3, 5, 2, 2, 2, 1, 3, 5, 6, 6, 4 };
            int res = ds.Calculate(numsArray);
            int wait = 225;
            Assert.AreEqual(wait, res);
        }
    }
}