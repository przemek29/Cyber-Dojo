using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL
{
    class Table
    {
        public int Width
        {
            get { return cellTable.GetLength(1); }
        }

        public int Height
        {
            get { return cellTable.GetLength(0); }
        }

        private Cell[,] cellTable;
        private bool[,] p;

        public Table(bool[,] inputTable)
        {
            Initialization(inputTable);
        }

        private void Initialization(bool[,] inputTable)
        {
            int x = inputTable.GetLength(0);
            int y = inputTable.GetLength(1);

            this.cellTable = new Cell[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    this.cellTable[i, j] = new Cell(inputTable[i, j]);
                }
            }
        }

        public bool GetItem(int x, int y)
        {
            return cellTable[y, x].CurrentState;
        }

        public void NextStep()
        {
            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    ProcessSingleCell(i, j);
                }
            }

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    cellTable[i, j].GoToNextState();
                }
            }
        }

        private void ProcessSingleCell(int x, int y)
        {
            int neighbours = CountNeighbours(x, y);
            bool currentState = cellTable[x, y].CurrentState;

            if (currentState && neighbours < 2)
            {
                cellTable[x, y].NextState = false;
            }

            if (currentState && (neighbours == 2 || neighbours == 3))
            {
                cellTable[x, y].NextState = true;
            }

            if (!currentState && neighbours == 3)
            {
                cellTable[x, y].NextState = true;
            }

            if (currentState && neighbours > 3)
            {
                cellTable[x, y].NextState = false;
            }
        }

        public int CountNeighbours(int x, int y)
        {
            int n = 0;

            if (SafeGetCurrentState(x - 1, y - 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x - 1, y))
            {
                n++;
            }

            if (SafeGetCurrentState(x, y - 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x + 1, y))
            {
                n++;
            }

            if (SafeGetCurrentState(x, y + 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x + 1, y + 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x - 1, y + 1))
            {
                n++;
            }

            if (SafeGetCurrentState(x + 1, y - 1))
            {
                n++;
            }

            return n;
        }

        public bool[,] CurrentState
        {
            get
            {
                var output = new bool[Height, Width];

                for (int i = 0; i < Height; i++)
                {
                    for (int j = 0; j < Width; j++)
                    {
                        output[i, j] = cellTable[i, j].CurrentState;
                    }
                }
                return output;
            }
        }

        private bool SafeGetCurrentState(int x, int y)
        {
            if (x >= 0 && y >= 0 && x < Height && y < Width)
            {
                return cellTable[x, y].CurrentState;
            }

            return false;
        }
    }
}
