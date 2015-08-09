using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class TableTests
    {
        [Test]
        public void CheckDimensionsOfEmptyTable()
        {
            var table = new Table(new bool[3, 5]);

            var width = table.Width;
            var height = table.Height;

            Assert.AreEqual(5, width);
            Assert.AreEqual(3, height);
        }

        [Test]
        public void CheckDimensionsOfNoneEmptyTable()
        {
            var inputTable = new bool[,] { { false, true, false }, { true, false, false } };
            var table = new Table(inputTable);

            Assert.AreEqual(3, table.Width);
            Assert.AreEqual(2, table.Height);
        }

        [Test]
        public void ShouldReturnCorrectlyItem()
        {
            var inputTable = new bool[,] { { false, true, false }, { true, false, false } };
            var table = new Table(inputTable);

            Assert.AreEqual(false, table.GetItem(0, 0));
            Assert.AreEqual(true, table.GetItem(1, 0));
            Assert.AreEqual(false, table.GetItem(2, 0));

            Assert.AreEqual(true, table.GetItem(0, 1));
            Assert.AreEqual(false, table.GetItem(1, 1));
            Assert.AreEqual(false, table.GetItem(2, 1));

        }

        [Test]
        public void ShouldReturnCorrectNumbersOfNeighbours()
        {
            var inputTable = new bool[,] 
        {
            {false, true, true}, 
            {true, false, true}
        };

            var table = new Table(inputTable);

            Assert.AreEqual(2, table.CountNeighbours(0, 0));
            Assert.AreEqual(3, table.CountNeighbours(0, 1));
            Assert.AreEqual(4, table.CountNeighbours(1, 1));
        }

        [Test]
        public void ShouldReturnAllCells()
        {
            var inputTable = new bool[,] 
        {
            {false, true, false}, 
            {true, true, false}
        };

            var table = new Table(inputTable);

            var currentState = table.CurrentState;

            Assert.AreEqual(false, currentState[0, 0]);
            Assert.AreEqual(true, currentState[0, 1]);
            Assert.AreEqual(false, currentState[0, 2]);
            Assert.AreEqual(true, currentState[1, 0]);
            Assert.AreEqual(true, currentState[1, 1]);
            Assert.AreEqual(false, currentState[1, 2]);

        }

        [Test]
        public void CheckTheTypicalBoolTable()
        {
            var inputTable = new bool[,] 
        {
            {false, true, false}, 
            {true, true, false},
            {false, true, false}
        };

            var table = new Table(inputTable);

            var currentState = table.CurrentState;

            Assert.AreEqual(inputTable, currentState);
        }

    }
}
