using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL
{
    public class Cell
    {
        public bool CurrentState { get; private set; }
        public bool NextState { get; set; }

        public Cell(bool state)
        {
            this.CurrentState = state;
        }

        public void GoToNextState()
        {
            CurrentState = NextState;
        }
    }
}
