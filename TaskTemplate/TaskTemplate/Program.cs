using System;
using System.Configuration;
using System.IO;
using TaskTemplate.Models;

namespace TaskTemplate
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

            var outputData = new TaskSolver().GetOutputData(inputData);
            var output = new OutputDataSerializer().GetSerrializedOutput(outputData);

            File.WriteAllText(outputDataPath, output);

            Console.Write(output);
        }
    }
}
