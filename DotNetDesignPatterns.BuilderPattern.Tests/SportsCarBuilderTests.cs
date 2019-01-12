using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetDesignPatterns.BuilderPattern.Tests
{
    [TestClass]
    public class SportsCarBuilderTests
    {
        [TestMethod]
        public void TestSportsCarBuildler()
        {
            AutomobileBuilder builder = new SportsCarBuilder();
            AutomobileDirector director = new AutomobileDirector(builder);
            director.Construct();
            var parts = builder.GetResult().ShowParts();
            Assert.IsTrue(parts.Contains("Cool Curves"));
            Assert.IsTrue(parts.Contains("Fast Engine"));
        }
    }
}