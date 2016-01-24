using OptimizeDataCenter.Models;
using System.Collections.ObjectModel;

namespace TaskTemplate.Models
{
    public class InputData
    {
        public InputData()
        {
            UnavailableSlots = new Collection<Coordinate>();
            Servers = new Collection<Server>();
        }

        public int RowsNumber { get; set; }

        public int SlotsNumber { get; set; }

        public int UnavailableSlotsNumber { get; set; }

        public int PoolsNumber { get; set; }

        public int ServersNumber { get; set; }

        public Collection<Coordinate> UnavailableSlots { get; set; }

        public Collection<Server> Servers { get; set; }
    }
}
