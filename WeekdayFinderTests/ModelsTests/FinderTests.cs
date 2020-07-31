using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System.Collections.Generic;
using System;

namespace WeekdayFinderTests
{   
    [TestClass]
    public class FinderTests
    {
        [TestMethod]
        public void FinderObject_MakeFinderObject_True(){
            Finder f = new Finder();
            Assert.AreEqual(typeof(Finder),f.GetType());
        }
    }
}