using System.Linq;
using System.Text;

namespace TaskTemplate.Models
{
    public class OutputDataSerializer
    {
        private const string NotAllocatedServerValue = "x";

        public string GetSerializedOutput(OutputData outputData)
        {
            var result = new StringBuilder();

            foreach(var server in outputData.Servers.OrderBy(s => s.Id))
            {
                var line = server.Position == null ? 
                    NotAllocatedServerValue : 
                    string.Format("{0} {1} {2}", server.Id, server.Position.RowNumber, server.Position.SlotNumber);

                result.AppendLine(line);
            }

            return result.ToString();
        }
    }
}
