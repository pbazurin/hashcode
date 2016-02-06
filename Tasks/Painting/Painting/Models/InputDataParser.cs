using System;

namespace Painting.Models
{
    public class InputDataParser
    {
        public const char CellToBePaintedChar = '#';

        public InputData GetParsedModel(string input)
        {
            var result = new InputData();

            var lines = input.Split('\n');
            var firstLineValues = lines[0].Split(' ');

            result.RowsNumber = Int32.Parse(firstLineValues[0]);
            result.ColumnsNumber = Int32.Parse(firstLineValues[1]);

            result.Map = new bool[result.RowsNumber, result.ColumnsNumber];

            for (var i = 0; i < result.RowsNumber; i++)
            {
                for(var j =0; j < result.ColumnsNumber; j++)
                {
                    if (lines[i + 1][j] == CellToBePaintedChar)
                    {
                        result.Map[i, j] = true;
                    }
                }
            }

            return result;
        }
    }
}
