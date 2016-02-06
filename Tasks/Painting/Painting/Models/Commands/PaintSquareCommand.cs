namespace Painting.Models.Commands
{
    public class PaintSquareCommand : Command
    {
        public Point Center { get; set; }

        public uint Radius { get; set; }

        public override string ToString()
        {
            return string.Format("PAINT_SQUARE {0} {1} {2}", Center.RowNumber, Center.ColumnNumber, Radius);
        }
    }
}
