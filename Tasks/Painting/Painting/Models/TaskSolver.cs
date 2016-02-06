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
                        result.Commands.Add(new PaintLineCommand
                        {
                            StartPoint = new Point
                            {
                                RowNumber = i,
                                ColumnNumber = j
                            },
                            EndPoint = new Point
                            {
                                RowNumber = i,
                                ColumnNumber = j
                            }
                        });
                    }
                }
            }

            return result;
        }

        public int GetScore(InputData inputData, OutputData outputData)
        {
            return inputData.ColumnsNumber * inputData.RowsNumber - outputData.Commands.Count;
        }
    }
}
