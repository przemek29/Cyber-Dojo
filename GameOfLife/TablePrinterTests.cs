using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class TablePrinterTests
    {
        [Test]
        public void CheckThePrintString()
        {
            var inputTable = new bool[,] {
            {false, true}, 
            {true, true}
            };

            var printer = new TablePrinter();

            var output = printer.Print(inputTable);

            Assert.AreEqual(".*\n**", output);
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

            var printer = new TablePrinter();

            var output = printer.Print(inputTable);
            var expectedOutput = ".*.\n" +
                                 "**.\n" +
                                 ".*.";

            Assert.AreEqual(expectedOutput, output);
        }
    }
}
