using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class CellTests
    {
        [Test]
        public void InputCurrentStateTrueShouldReturnTrue()
        {
            var cell = new Cell(true);

            Assert.AreEqual(true, cell.CurrentState);
        }

        [Test]
        public void ShouldCorrectlyReturnFalse()
        {
            var cell = new Cell(true);

            cell.GoToNextState();

            Assert.AreEqual(false, cell.CurrentState);
        }

        [Test]
        public void ShouldCorrectlyChangeNextStateToCurrentState()
        {
            var cell = new Cell(false);

            cell.NextState = true;

            cell.GoToNextState();

            Assert.AreEqual(true, cell.CurrentState);
        }
    }


}
