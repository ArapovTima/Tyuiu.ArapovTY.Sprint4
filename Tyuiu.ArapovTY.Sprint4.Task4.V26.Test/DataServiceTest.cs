using Tyuiu.ArapovTY.Sprint4.Task4.V26.Lib;
namespace Tyuiu.ArapovTY.Sprint4.Task4.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mtrx = new int[5, 5] { { 5, 4, 1, 1, 2 },
                                          { 3, 2, 4, 3, 5 },
                                          { 5, 2, 3, 2, 2 },
                                          { 2, 5, 1, 1, 4 },
                                          { 5, 3, 4, 3, 2 } };
            int[,] res = ds.Calculate(mtrx);
        }
    }
}