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
            string str = Finder.DayOfWeek("7/11/2014");
            Assert.AreEqual(str,"Friday");
        }
         [TestMethod]
           public void dayOfWeek_ReturnDayOfWeek2_True(){
            string str = Finder.DayOfWeek("07/11/2014");
            Assert.AreEqual(str,"Friday");
        }

         [TestMethod]
           public void dayOfWeek_ReturnDayOfWeek3_True(){
            string str = Finder.DayOfWeek("07/11/14");
            Assert.AreEqual(str,"Friday");
        }

          [TestMethod]
           public void dayOfWeek_ReturnDayOfWeek4_True(){
            string str = Finder.DayOfWeek("07-11-14");
            Assert.AreEqual(str,"Friday");
        }
    }
}