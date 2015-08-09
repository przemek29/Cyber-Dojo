using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class RuleOneTests
    {
        [Test]
        public void Example1()
        {
            var inputTable = new bool[,] {
            {false, true}, 
            {true, false}
            };

            var table = new Table(inputTable);

            table.NextStep();

            Assert.AreEqual(false, table.GetItem(1, 0));
            Assert.AreEqual(false, table.GetItem(1, 1));
            Assert.AreEqual(false, table.GetItem(0, 1));
            Assert.AreEqual(false, table.GetItem(0, 0));

        }

        [Test]
        public void Example2()
        {
            var inputTable = new bool[,] {
            {false, true, false, true}, 
            {true, false, false, false}
            };

            var table = new Table(inputTable);

            table.NextStep();

            Assert.AreEqual(false, table.GetItem(1, 0));
            Assert.AreEqual(false, table.GetItem(3, 0));

            Assert.AreEqual(false, table.GetItem(1, 0));
        }



    }
}
