using Painting.Models.Commands;
using System.Collections.Generic;

namespace Painting.Models
{
    public class OutputData
    {
        public OutputData()
        {
            Commands = new List<Command>();
        }

        public List<Command> Commands { get; set; }
    }
}
