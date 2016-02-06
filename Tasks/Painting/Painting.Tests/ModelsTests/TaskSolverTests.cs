using Microsoft.VisualStudio.TestTools.UnitTesting;
using Painting.Models;

namespace Painting.Tests
{
    [TestClass]
    public class TaskSolverTests
    {
        [TestMethod]
        public void TeskSolver_Returns_Output_Data()
        {
            var solver = new TaskSolver();

            var result = solver.GetOutputData(new InputData());

            Assert.IsNotNull(result);
        }
    }
}
