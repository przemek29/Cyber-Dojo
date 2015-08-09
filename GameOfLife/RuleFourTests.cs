using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class RuleFourTests
    {
        [Test]
        public void Example1()
        {
            var inputTable = new bool[,] {
            {false, true}, 
            {true, true}
            };

            var table = new Table(inputTable);

            table.NextStep();

            Assert.AreEqual(true, table.GetItem(0, 0));
        }

        [Test]
        public void Example2()
        {
            var inputTable = new bool[,] {
            {true, true}, 
            {true, false}
            };

            var table = new Table(inputTable);

            table.NextStep();

            Assert.AreEqual(true, table.GetItem(1, 1));
        }


    }
}
