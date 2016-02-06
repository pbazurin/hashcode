using Microsoft.VisualStudio.TestTools.UnitTesting;
using Painting.Models;

namespace Painting.Tests.ModelsTests
{
    [TestClass]
    public class OutputDataSerializerTests
    {
        [TestMethod]
        public void Serrializer_Returns_Output()
        {
            var serr = new OutputDataSerializer();

            var output = serr.GetSerializedOutput(new OutputData());

            Assert.IsNotNull(output);
        }
    }
}
