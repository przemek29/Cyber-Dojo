using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class RuleTwoTests
    {
        [Test]
        public void Example1()
        {
            var inputTable = new bool[,] {
            {true, true}, 
            {true, true},
            {true, false}
            };

            var table = new Table(inputTable);

            table.NextStep();

            Assert.AreEqual(false, table.GetItem(0, 1));
        }

        [Test]
        public void Example2()
        {
            var inputTable = new bool[,] {
            {true, true, false}, 
            {true, true, true}
            };

            var table = new Table(inputTable);

            table.NextStep();

            Assert.AreEqual(false, table.GetItem(1, 0));
            Assert.AreEqual(false, table.GetItem(1, 1));
        }

    }
}
