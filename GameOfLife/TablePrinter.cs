using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GOL
{
    class TablePrinter
    {
        public string Print(bool[,] inputTable)
        {
            var height = inputTable.GetLength(0);
            var length = inputTable.GetLength(1);

            List<string> output = new List<string>();

            for (int i = 0; i < height; i++)
            {

                StringBuilder sb = new StringBuilder();

                for (int j = 0; j < length; j++)
                {
                    if (inputTable[i, j])
                        sb.Append("*");
                    else
                        sb.Append(".");

                }
                output.Add(sb.ToString());
            }

            return string.Join("\n", output);
        }
    }
}
