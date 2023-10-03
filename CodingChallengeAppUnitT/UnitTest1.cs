using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace CodingChallengeAppUnitT
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "yes";
            bool result = Program.IsYes(input);
            Assert.IsTrue(result);

        }
    }
}
