using System.Text;

namespace Painting.Models
{
    public class OutputDataSerializer
    {
        public string GetSerializedOutput(OutputData outputData)
        {
            var result = new StringBuilder();

            result.AppendLine(outputData.Commands.Count.ToString());

            foreach (var command in outputData.Commands)
            {
                result.AppendLine(command.ToString());
            }

            return result.ToString();
        }

        public string GetSerrializedInput(InputData inputData, OutputData outputData)
        {
            var map = new bool[inputData.RowsNumber, inputData.ColumnsNumber];

            foreach (var command in outputData.Commands)
            {
                command.Map = map;
                command.Do();
            }

            var result = new StringBuilder();

            for (var i = 0; i < inputData.RowsNumber; i++)
            {
                for (var j = 0; j < inputData.ColumnsNumber; j++)
                {
                    result.Append(map[i, j] ? InputDataParser.CellToBePaintedChar : InputDataParser.CellBlankChar);
                }

                result.AppendLine();
            }

            return result.ToString();
        }
    }
}
