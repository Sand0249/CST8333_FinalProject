/** 
 * Author: Simranjit Singh Sandhu
 * Date  : April 15, 2018
 * Class : TestTotalRecords.cs
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment4;

namespace Assignment4Test
{
    /// <summary>
    /// test class for testing average marks and total number of records from dataabase
    /// </summary>
    [TestClass]
    public class TestTotalRecords
    {
        /// <summary>
        /// instantiates variable string for using in class
        /// </summary>
        public string query ;

        /// <summary>
        /// method for testing total number of records by running an expected value against query from dataabase
        /// </summary>
        [TestMethod]
        public void TestRecords()
        {
            // Arrange
            int Expected = 100945;                // instantiating int variable as expected value for assert statement

            //Act
            Derived open = new Derived();
            int actual = int.Parse(open.DbAction(query));

            // Assert
            Assert.AreEqual(Expected,actual);        // assert statement
        }

        /// <summary>
        /// method for testing average method from MarksCalculator class by running method against given expected value
        /// </summary>
        [TestMethod]
        public void TestMarks()
        {
            // Arrange
            int Expected = 25;

            //Act
            MarksCalculator open = new MarksCalculator();
            int actual = open.Average(25,25);
  
            // Assert
            Assert.AreEqual(Expected, actual);        // assert statement
        }

    }           // end of class
}               // end of namespace
