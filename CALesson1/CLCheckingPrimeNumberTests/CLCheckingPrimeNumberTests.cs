using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CLCheckingPrimeNumberTests
{
    [TestClass]
    public class CLCheckingPrimeNumberTests
    {
        [TestMethod]
        public void CheckPrimeNumTest()
        {
            //arrage
            int[] arrayN = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29};
            string expected = "This is a prime number";
                         
            CLCheckingPrimeNumber.CheckingPrimeNumber res = new CLCheckingPrimeNumber.CheckingPrimeNumber();
            //act
            for (int i = 0; i < arrayN.Length; i++)
            {
                //assert
                Assert.AreEqual(expected, res.CheckPrimeNumber(arrayN[i]));
            }            
        }

        [TestMethod]
        public void CheckNoPrimeNumTest()
        {
            //arrage
            int[] arrayN = { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 };
            string expected = "It's not a prime number";

            CLCheckingPrimeNumber.CheckingPrimeNumber res = new CLCheckingPrimeNumber.CheckingPrimeNumber();
            //act
            for (int i = 0; i < arrayN.Length; i++)
            {
                //assert
                Assert.AreEqual(expected, res.CheckPrimeNumber(arrayN[i]));
            }
        }

        [TestMethod]
        public void CheckNoPrimeNumTest2()
        {
            //arrage
            int[] arrayN = { 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24 };
            string expected = "This is a prime number";

            CLCheckingPrimeNumber.CheckingPrimeNumber res = new CLCheckingPrimeNumber.CheckingPrimeNumber();
            //act
            for (int i = 0; i < arrayN.Length; i++)
            {
                //assert
                Assert.AreNotEqual(expected, res.CheckPrimeNumber(arrayN[i]));
            }
        }
    }
}
