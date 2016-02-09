using System;

namespace Painting.Models.Commands
{
    public class PaintLineCommand : Command
    {
        public Point StartPoint { get; set; }

        public Point EndPoint { get; set; }

        public override string ToString()
        {
            return string.Format("PAINT_LINE {0} {1} {2} {3}",
                StartPoint.RowNumber,
                StartPoint.ColumnNumber,
                EndPoint.RowNumber,
                EndPoint.ColumnNumber);
        }

        public override void Do()
        {
            if (StartPoint.RowNumber == EndPoint.RowNumber)
            {
                for (var i = StartPoint.ColumnNumber; i <= EndPoint.ColumnNumber; i++)
                {
                    if(Map[StartPoint.RowNumber, i])
                    {
                        throw new InvalidOperationException();
                    }

                    Map[StartPoint.RowNumber, i] = true;
                }
            }
            else
            {
                for (var i = StartPoint.RowNumber; i <= EndPoint.RowNumber; i++)
                {
                    if (Map[i, StartPoint.ColumnNumber])
                    {
                        throw new InvalidOperationException();
                    }

                    Map[i, StartPoint.ColumnNumber] = true;
                }
            }
        }

        public override void Undo()
        {
            if (StartPoint.RowNumber == EndPoint.RowNumber)
            {
                for (var i = StartPoint.ColumnNumber; i <= EndPoint.ColumnNumber; i++)
                {
                    if (!Map[StartPoint.RowNumber, i])
                    {
                        throw new InvalidOperationException();
                    }

                    Map[StartPoint.RowNumber, i] = false;
                }
            }
            else
            {
                for (var i = StartPoint.RowNumber; i <= EndPoint.RowNumber; i++)
                {
                    if (!Map[i, StartPoint.ColumnNumber])
                    {
                        throw new InvalidOperationException();
                    }

                    Map[i, StartPoint.ColumnNumber] = false;
                }
            }
        }
    }
}
