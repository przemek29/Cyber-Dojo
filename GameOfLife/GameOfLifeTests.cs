using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using GOL;

namespace GameOfLifeTests
{
    [TestFixture]
    public class GameOfLifeTests
    {
        [Test]
        public void SimpleAsymetricExample()
        {
            var input = ".*.\n" +
                        "**.\n" +
                        ".*.";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = "**.\n" +
                                 "***\n" +
                                 "**.";

            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void BlinkerExample()
        {
            var input = "...\n" +
                        "***\n" +
                        "...";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = ".*.\n" +
                                 ".*.\n" +
                                 ".*.";

            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void ToadExample()
        {
            var input = "....\n" +
                        ".***\n" +
                        "***.\n" +
                        "....";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = "..*.\n" +
                                 "*..*\n" +
                                 "*..*\n" +
                                 ".*..";

            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void BeaconExample()
        {
            var input = "**..\n" +
                        "**..\n" +
                        "..**\n" +
                        "..**";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = "**..\n" +
                                 "*...\n" +
                                 "...*\n" +
                                 "..**";

            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void StaticBlockExample()
        {
            var input = "....\n" +
                        ".**.\n" +
                        ".**.\n" +
                        "....";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = "....\n" +
                                 ".**.\n" +
                                 ".**.\n" +
                                 "....";

            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void StaticBeehiveExample()
        {
            var input = "....\n" +
                        ".**.\n" +
                        "*..*\n" +
                        ".**.";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = "....\n" +
                                 ".**.\n" +
                                 "*..*\n" +
                                 ".**.";

            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void StaticLoafExample()
        {
            var input = ".**.\n" +
                        "*..*\n" +
                        ".*.*\n" +
                        "..*.";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = ".**.\n" +
                                 "*..*\n" +
                                 ".*.*\n" +
                                 "..*.";

            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void StaticBoatExample()
        {
            var input = "**.\n" +
                        "*.*\n" +
                        ".*.";

            var gol = new GameOfLife(input);

            gol.NextStep();

            var expectedOutput = "**.\n" +
                                 "*.*\n" +
                                 ".*.";


            Assert.AreEqual(expectedOutput, gol.CurrentState);
        }

        [Test]
        public void CyclicSetUpShouldBeTheSameAfter3Periods()
        {
            var input = "...............\n" +
                        "...***...***...\n" +
                        "...............\n" +
                        ".*....*.*....*.\n" +
                        ".*....*.*....*.\n" +
                        ".*....*.*....*.\n" +
                        "...***...***...\n" +
                        "...............\n" +
                        "...***...***...\n" +
                        ".*....*.*....*.\n" +
                        ".*....*.*....*.\n" +
                        ".*....*.*....*.\n" +
                        "...............\n" +
                        "...***...***...\n" +
                        "...............";


            var gol = new GameOfLife(input);

            gol.NextStep();
            gol.NextStep();
            gol.NextStep();

            Assert.AreEqual(input, gol.CurrentState);
        }


    }
}
