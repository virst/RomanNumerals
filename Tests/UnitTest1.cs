using static RomanNumerals.RomanNumeralsUtils;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2000, "MM")]
        [DataRow(1666, "MDCLXVI")]
        [DataRow(400, "CD")]
        [DataRow(9, "IX")]
        public void BaseTest(int n, string r)
        {
            var s = ToRoman(n);
            Assert.AreEqual(r, s);
        }


        [TestMethod]
        [DataRow("MDCLXVI", 1666)]
        [DataRow("MM", 2000)]
        [DataRow("I", 1)]
        [DataRow("IX", 9)]
        public void ReverceTest(string r, int n)
        {
            var i = FromRoman(r);
            Assert.AreEqual(n, i);
        }


        [TestMethod]
        public void RandomTest()
        {
            Random rnd = new ();
            for (int i = 0; i < 50; i++)
            {
                var n = rnd.Next(1, 4000);
                var r = FromRoman(ToRoman(n));
                Assert.AreEqual(n, r);
            }
        }
    }
}
