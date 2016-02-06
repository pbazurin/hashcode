using System;

namespace Painting.Models.Commands
{
    public class PaintLineCommand : Command
    {
        public PaintLineCommand() : base()
        {
        }

        public PaintLineCommand(bool[,] map) : base(map)
        {
        }

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
                    if(_map[StartPoint.RowNumber, i])
                    {
                        throw new InvalidOperationException();
                    }

                    _map[StartPoint.RowNumber, i] = true;
                }
            }
            else
            {
                for (var i = StartPoint.RowNumber; i <= EndPoint.RowNumber; i++)
                {
                    if (_map[i, StartPoint.ColumnNumber])
                    {
                        throw new InvalidOperationException();
                    }

                    _map[i, StartPoint.ColumnNumber] = true;
                }
            }
        }

        public override void Undo()
        {
            if (StartPoint.RowNumber == EndPoint.RowNumber)
            {
                for (var i = StartPoint.ColumnNumber; i <= EndPoint.ColumnNumber; i++)
                {
                    if (!_map[StartPoint.RowNumber, i])
                    {
                        throw new InvalidOperationException();
                    }

                    _map[StartPoint.RowNumber, i] = false;
                }
            }
            else
            {
                for (var i = StartPoint.RowNumber; i <= EndPoint.RowNumber; i++)
                {
                    if (!_map[i, StartPoint.ColumnNumber])
                    {
                        throw new InvalidOperationException();
                    }

                    _map[i, StartPoint.ColumnNumber] = false;
                }
            }
        }
    }
}
