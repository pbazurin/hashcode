namespace Painting.Models.Commands
{
    public class EraseCellCommand : Command
    {
        public Point CellPoint { get; set; }

        public override string ToString()
        {
            return string.Format("ERASE_CELL {0} {1}", CellPoint.RowNumber, CellPoint.ColumnNumber);
        }
    }
}
