using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL
{
    class GameOfLife
    {
        public string CurrentState
        {
            get
            {
                return printer.Print(table.CurrentState);
            }
        }

        private Table table;

        private TablePrinter printer;

        public GameOfLife(string input)
        {
            var parser = new Parser();

            var parsedInput = parser.Parse(input);

            table = new Table(parsedInput);

            printer = new TablePrinter();

        }

        public void NextStep()
        {
            table.NextStep();
        }
    }
}
