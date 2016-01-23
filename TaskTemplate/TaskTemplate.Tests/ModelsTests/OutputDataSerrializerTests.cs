using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskTemplate.Models;

namespace TaskTemplate.Tests.ModelsTests
{
    [TestClass]
    public class OutputDataSerrializerTests
    {
        [TestMethod]
        public void Serrializer_Returns_Output()
        {
            var serr = new OutputDataSerrializer();

            var output = serr.GetSerrializedOutput(new OutputDataModel());

            Assert.IsNotNull(output);
        }
    }
}
