using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _77202708_PaintApplication;

namespace PaintApplicationTest
{
    [TestClass]
    public class MethodCheckingTest
    {
        [TestMethod]
        public void isRectangle()
        {

            //arrange
            bool test;
            MethodChecking method = new MethodChecking();


            //act
            test = method.isRectangle("RECTANGLE");

            //assert
            Assert.IsTrue(test);
        }
    }
}
