﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using _77202708_PaintApplication;

namespace PaintApplicationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void isCircle()
        {
            //arrange
            bool test;
            MethodCheckingCircle ff = new MethodCheckingCircle();

            //act
            test = ff.isCircle("CIRCLE");


            //assert
            Assert.IsTrue(test);
        }
    }
}
