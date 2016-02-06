using System.Text;

namespace Painting.Models
{
    public class OutputDataSerializer
    {
        public string GetSerializedOutput(OutputData outputData)
        {
            var result = new StringBuilder();

            foreach (var command in outputData.Commands)
            {
                result.AppendLine(command.ToString());
            }

            return result.ToString();
        }
    }
}
