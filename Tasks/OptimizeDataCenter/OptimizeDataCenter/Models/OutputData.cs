using OptimizeDataCenter.Models;
using System.Collections.ObjectModel;

namespace TaskTemplate.Models
{
    public class OutputData
    {
        public OutputData()
        {
            Servers = new Collection<Server>();
        }

        public Collection<Server> Servers { get; set; }
    }
}
