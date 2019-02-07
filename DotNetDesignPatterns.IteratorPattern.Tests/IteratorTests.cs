using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DotNetDesignPatterns.IteratorPattern.Tests
{
    [TestClass]
    public class IteratorTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var a = new Aggregate<string>();
            a[0] = "Bobby";
            a[1] = "Jamal";
            a[2] = "Chase";
            a[3] = "Chalupa";


            var i = a.CreateIterator();

            var index = 0;
            var item = i.First();
            Assert.AreEqual("Bobby", item);
            while (item != null)
            {
                item = i.Next();
                index++;
                switch (index)
                {
                    case 0:
                        Assert.AreEqual("Bobby", item);
                        break;
                    case 1:
                        Assert.AreEqual("Jamal", item);
                        break;
                    case 2:
                        Assert.AreEqual("Chase", item);
                        break;
                    case 3:
                        Assert.AreEqual("Chalupa", item);
                        break;
                }
            }
        }
    }
}
