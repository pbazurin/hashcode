using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskTemplate.Models;

namespace TaskTemplate.Tests.ModelsTests
{
    [TestClass]
    public class OutputDataSerializerTests
    {
        [TestMethod]
        public void Serrializer_Returns_Output()
        {
            var serr = new OutputDataSerializer();

            var output = serr.GetSerrializedOutput(new OutputData());

            Assert.IsNotNull(output);
        }
    }
}
