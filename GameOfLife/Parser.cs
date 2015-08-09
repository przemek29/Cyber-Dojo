using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL
{
    class Parser
    {
        public bool[,] Parse(string input)
        {
            char[] delimiterChar = { '\n' };

            var output = input.Split(delimiterChar);

            if (output.Length == 0 || string.IsNullOrEmpty(output[0]))
                throw new System.ArgumentException("Input value cannot be null", "Length");

            var height = output.Length;
            var length = output[0].Length;

            var result = new bool[height, length];

            for (int i = 0; i < height; i++)
            {
                if (output[i].Length != length)
                    throw new System.ArgumentException("The length of input string must be the same", "Length");

                for (int j = 0; j < length; j++)
                {
                    result[i, j] = ParseSingleCell(output[i][j]);
                }
            }
            return result;
        }

        private bool ParseSingleCell(char c)
        {
            bool alive = true;
            bool dead = false;

            if (c == '.')
                return dead;

            if (c == '*')
                return alive;

            throw new System.ArgumentException("You cannot input a sign different form . and *", "WrongInput");
        }   
    }
}
