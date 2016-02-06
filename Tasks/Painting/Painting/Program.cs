using System;
using System.Configuration;
using System.IO;
using Painting.Models;

namespace Painting
{
    class Program
    {
        public const string InputDataPathKey = "InputDataPath";
        public const string OutputDataPathKey = "OutputDataPath";

        static void Main(string[] args)
        {
            var inputDataPath = ConfigurationManager.AppSettings[InputDataPathKey];
            var outputDataPath = ConfigurationManager.AppSettings[OutputDataPathKey];

            var input = File.ReadAllText(inputDataPath);
            var inputData = new InputDataParser().GetParsedModel(input);

            var taskSolver = new TaskSolver();
            var outputData = taskSolver.GetOutputData(inputData);
            var output = new OutputDataSerializer().GetSerializedOutput(outputData);

            File.WriteAllText(outputDataPath, output);

            Console.Write(output);

            Console.WriteLine();
            Console.WriteLine(string.Format("Score: {0}", taskSolver.GetScore(inputData, outputData)));
        }
    }
}
