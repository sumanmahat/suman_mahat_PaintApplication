using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _77202708_PaintApplication;

namespace PaintApplicationTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void isPolygon()
        {
            //arrange
            bool test;
            MethodCheckingPolygon ff = new MethodCheckingPolygon();

            //act
            test = ff.isCircle("POLYGON");


            //assert
            Assert.IsTrue(test);
        }
    }
}
