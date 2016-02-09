using System;

namespace Painting.Models.Commands
{
    public class EraseCellCommand : Command
    {
        public Point CellPoint { get; set; }

        public override string ToString()
        {
            return string.Format("ERASE_CELL {0} {1}", CellPoint.RowNumber, CellPoint.ColumnNumber);
        }

        public override void Do()
        {
            if (!Map[CellPoint.RowNumber, CellPoint.ColumnNumber])
            {
                throw new InvalidOperationException();
            }

            Map[CellPoint.RowNumber, CellPoint.ColumnNumber] = false;
        }

        public override void Undo()
        {
            if(Map[CellPoint.RowNumber, CellPoint.ColumnNumber])
            {
                throw new InvalidOperationException();
            }

            Map[CellPoint.RowNumber, CellPoint.ColumnNumber] = true;
        }
    }
}
