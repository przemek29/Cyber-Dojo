using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class ParserTests
    {
        [Test]
        [ExpectedException("System.ArgumentException")]
        public void CheckTheEmptyInputString()
        {
            var input = "";

            var parser = new Parser();

            parser.Parse(input);
        }

        [Test]
        [ExpectedException("System.ArgumentException")]
        public void CheckTheIrregularInputString()
        {
            var input = "..\n.";

            var parser = new Parser();

            parser.Parse(input);
        }

        [Test]
        public void CheckTheSizeOfResultBoolString()
        {
            var input = "..";

            var parser = new Parser();

            var output = parser.Parse(input);

            Assert.AreEqual(1, output.GetLength(0));
            Assert.AreEqual(2, output.GetLength(1));
        }

        [Test]
        public void CheckTheChangeOfSignToBool()
        {
            var input = "*.";

            var parser = new Parser();

            var output = parser.Parse(input);

            Assert.AreEqual(true, output[0, 0]);
            Assert.AreEqual(false, output[0, 1]);
        }

        [Test]
        [ExpectedException("System.ArgumentException")]
        public void CheckTheWrongSign()
        {
            var input = "input";

            var parser = new Parser();

            parser.Parse(input);
        }

        [Test]
        public void CheckThe2D_InputString()
        {
            var input = ".*\n..\n**";

            var parser = new Parser();

            var output = parser.Parse(input);

            Assert.AreEqual(false, output[0, 0]);
            Assert.AreEqual(true, output[0, 1]);

            Assert.AreEqual(false, output[1, 0]);
            Assert.AreEqual(false, output[1, 1]);

            Assert.AreEqual(true, output[2, 0]);
            Assert.AreEqual(true, output[2, 1]);

        }

        [Test]
        public void CheckTheTypicalInput()
        {
            var input = ".*.\n" +
                        "**.\n" +
                        ".*.";

            var parser = new Parser();

            var output = parser.Parse(input);

            var expectedOutput = new bool[,]
        {
            {false, true, false},
            {true, true, false},
            {false, true, false}
        };

            Assert.AreEqual(expectedOutput, output);
        }

    }
}
