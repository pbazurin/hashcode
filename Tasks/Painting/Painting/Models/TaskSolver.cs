using Painting.Models.Commands;

namespace Painting.Models
{
    public class TaskSolver
    {
        public OutputData GetOutputData(InputData inputData)
        {
            var result = new OutputData();

            // TODO: improve solver
            for (var i = 0; i < inputData.RowsNumber; i++)
            {
                for (var j = 0; j < inputData.ColumnsNumber; j++)
                {
                    if (inputData.Map[i, j])
                    {
                        var currentCommand = GetBestCommandForPaintedCell(inputData, i, j);

                        // To erase figure from map
                        currentCommand.Undo();

                        result.Commands.Add(currentCommand);
                    }
                }
            }

            return result;
        }

        public int GetScore(InputData inputData, OutputData outputData)
        {
            return inputData.ColumnsNumber * inputData.RowsNumber - outputData.Commands.Count;
        }

        private Command GetBestCommandForPaintedCell(InputData inputData, int rowNumber, int columnNumber)
        {
            var command = new PaintLineCommand(inputData.Map)
            {
                StartPoint = new Point
                {
                    RowNumber = rowNumber,
                    ColumnNumber = columnNumber
                },
                EndPoint = new Point
                {
                    RowNumber = rowNumber,
                    ColumnNumber = columnNumber
                }
            };

            bool isNextRowShouldBeChecked = true;
            bool isNextColumnShouldBeChecked = true;

            var lineLength = 1;

            var rowsPainted = 0;
            var columnsPainted = 0;

            while (isNextRowShouldBeChecked || isNextColumnShouldBeChecked)
            {
                isNextRowShouldBeChecked = isNextRowShouldBeChecked
                    && rowNumber + lineLength < inputData.RowsNumber
                    && inputData.Map[rowNumber + lineLength, columnNumber];

                if (isNextRowShouldBeChecked)
                {
                    rowsPainted++;
                }

                isNextColumnShouldBeChecked = isNextColumnShouldBeChecked
                    && columnNumber + lineLength < inputData.ColumnsNumber
                    && inputData.Map[rowNumber, columnNumber + lineLength];

                if (isNextColumnShouldBeChecked)
                {
                    columnsPainted++;
                }

                lineLength++;
            }

            if(rowsPainted > columnsPainted)
            {
                command.EndPoint.RowNumber = rowNumber + rowsPainted;
            } else
            {
                command.EndPoint.ColumnNumber = columnNumber + columnsPainted;
            }

            return command;
        }
    }
}
