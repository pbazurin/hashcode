namespace OptimizeDataCenter.Models
{
    public class Server
    {
        public int Id { get; set; }

        public int Size { get; set; }

        public int Capacity { get; set; }

        public int PoolNumber { get; set; }

        public Coordinate Position { get; set; }
    }
}
