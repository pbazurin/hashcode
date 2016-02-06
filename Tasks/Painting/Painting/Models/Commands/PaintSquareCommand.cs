using System;

namespace Painting.Models.Commands
{
    public class PaintSquareCommand : Command
    {
        public PaintSquareCommand() : base()
        {
        }

        public PaintSquareCommand(bool[,] map) : base(map)
        {
        }

        public Point Center { get; set; }

        public uint Radius { get; set; }

        public override string ToString()
        {
            return string.Format("PAINT_SQUARE {0} {1} {2}", Center.RowNumber, Center.ColumnNumber, Radius);
        }

        public override void Do()
        {
            if(Center.RowNumber < Radius || Center.ColumnNumber < Radius)
            {
                throw new InvalidOperationException();
            }

            for(var i = Center.RowNumber - Radius; i < Center.RowNumber + Radius; i++)
            {
                for (var j = Center.ColumnNumber - Radius; i < Center.ColumnNumber + Radius; i++)
                {
                    if (_map[i, j])
                    {
                        throw new InvalidOperationException();
                    }

                    _map[i, j] = true;
                }
            }
        }

        public override void Undo()
        {
            if (Center.RowNumber < Radius || Center.ColumnNumber < Radius)
            {
                throw new InvalidOperationException();
            }

            for (var i = Center.RowNumber - Radius; i < Center.RowNumber + Radius; i++)
            {
                for (var j = Center.ColumnNumber - Radius; i < Center.ColumnNumber + Radius; i++)
                {
                    if (!_map[i, j])
                    {
                        throw new InvalidOperationException();
                    }

                    _map[i, j] = false;
                }
            }
        }
    }
}
