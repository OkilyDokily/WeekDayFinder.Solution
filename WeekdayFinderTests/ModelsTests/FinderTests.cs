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
        public void dayOfWeek_ReturnDayOfWeek_True(){
            string str = Finder.dayOfWeek("7/11/2014");
            Assert.AreEqual(str,"Friday");
        }
    }
}