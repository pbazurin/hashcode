using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskTemplate.Models;

namespace TaskTemplate.Tests
{
    [TestClass]
    public class InputDataParserTests
    {
        [TestMethod]
        public void Parser_Returns_Input_Data_Model()
        {
            var parser = new InputDataParser();

            var result = parser.GetParsedModel(string.Empty);

            Assert.IsNotNull(result);
        }
    }
}
