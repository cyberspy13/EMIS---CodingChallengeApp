using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CodingChallengeAppUnitTest;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace CodingChallengeAppUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        public static extern int MessageBox(IntPtr hWnd, String text, String caption, uint type);
        public void TestMethod1()
        {
            RetPatientData pr = new RetPatientData();
          
        }
    }
}
