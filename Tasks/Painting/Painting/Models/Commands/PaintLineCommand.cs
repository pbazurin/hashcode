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
    }
}
