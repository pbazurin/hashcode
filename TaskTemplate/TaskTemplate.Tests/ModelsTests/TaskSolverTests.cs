using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskTemplate.Models;

namespace TaskTemplate.Tests
{
    [TestClass]
    public class TaskSolverTests
    {
        [TestMethod]
        public void TeskSolver_Returns_Output_Data()
        {
            var solver = new TaskSolver();

            var result = solver.GetOutputData(new InputDataModel());

            Assert.IsNotNull(result);
        }
    }
}
