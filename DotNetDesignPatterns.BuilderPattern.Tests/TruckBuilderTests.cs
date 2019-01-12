using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetDesignPatterns.BuilderPattern.Tests
{

    [TestClass]
    public class TruckBuilderTests
    {
        [TestMethod]
        public void TestTruckBuilder()
        {
            AutomobileBuilder builder = new TruckBuilder();
            AutomobileDirector director = new AutomobileDirector(builder);
            director.Construct();
            var parts = builder.GetResult().ShowParts();
            Assert.IsTrue(parts.Contains("Big Lift Kit"));
            Assert.IsTrue(parts.Contains("Big Loud Engine"));
        }
    }
}