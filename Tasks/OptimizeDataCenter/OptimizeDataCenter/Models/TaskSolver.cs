namespace TaskTemplate.Models
{
    public class TaskSolver
    {
        public OutputData GetOutputData(InputData inputData)
        {
            var result = new OutputData
            {
                Servers = inputData.Servers
            };

            // TODO: add some logic here

            return result;
        }
    }
}
