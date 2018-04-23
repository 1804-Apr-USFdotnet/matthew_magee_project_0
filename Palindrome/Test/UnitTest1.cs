using System;
using System.Security.Policy;
using Lib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            //Arrange
            string badString = "rac..,,,carr";
            string goodString = "rac..,,,ecar";
            var palindromCheck = new CheckPalindrome();

            //Act

            
            bool actual = palindromCheck.PalendromSearch(goodString);

            //Assert
            
            Assert.IsTrue(actual);
        }
    }
}
