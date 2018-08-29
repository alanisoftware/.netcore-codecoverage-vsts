using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCodeCoverageProject.Tests
{
    [TestClass]
    public class AdditionTests
    {
        [TestMethod]
        public void WhenAddingTwoValues_ShouldReturnValueTotal()
        {
            // ARRANGE
            var addition = new Addition();

            // ACT
            var result = addition.Add(1, 2);

            // ASSERT
            Assert.AreEqual(result, 3);
        }
    }
}
