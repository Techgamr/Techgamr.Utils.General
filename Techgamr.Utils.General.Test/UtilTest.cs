using NUnit.Framework;

namespace Techgamr.Utils.General.Test
{
    [TestFixture]
    public class UtilTest
    {
        [TestCase(new object[]{0}, "[0]", "ThisShouldNeverBeInTheResult")]
        [TestCase(new object[]{0, 5, 2}, "[0, 5, 2]", ", ")]
        [TestCase(new object[]{1200, 15423, 20000}, "[1200,15423,20000]", ",")]
        [TestCase(new object[]{2147483647, 1, -2147483647}, "[2147483647 1 -2147483647]", " ")]
        public void ArrayToStringTest(object[] actual, string expected, string joiner) => Assert.IsTrue(Util.ArrayToString(actual, joiner) == expected);

        [Test]
        public void ArrayToStringGeneric()
        {
            var res = Util.ArrayToString(new[] {"thing1", "thing2"});
            Assert.IsTrue(res == "[thing1, thing2]");
        }
    }
}
