using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace CodingChallengeTestUnit
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIsYesMethod_WhenYesWithDifferentCases_ReturnsTrue()
        {
           
            string input = "yes";
            string input2 = "Yes";
            string input3 = "YES";

            bool result = Program.IsYes(input);
            bool result2 = Program.IsYes(input2);
            bool result3 = Program.IsYes(input3);

            Assert.IsTrue(result);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);

        }


        [TestMethod]
        public void TestIsYesMethod_WhenYesWithDifferentCases_ReturnsFalse()
        {
            string input = "no";
            string input2 = "No";
            string input3 = "NO";

            bool result = Program.IsYes(input);
            bool result2 = Program.IsYes(input2);
            bool result3 = Program.IsYes(input3);

            Assert.IsFalse(result);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);

        }

    }
}