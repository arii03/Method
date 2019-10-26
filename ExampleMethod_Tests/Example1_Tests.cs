using ExampleMethod;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExampleMethod_Tests
{
    [TestClass]
    public class Example1_Tests
    {
        [TestMethod]
        public void TestExample1_1()
        {
            bool respMethod = Example1.Calcolo1();
            Assert.AreEqual(false, respMethod);
        }
    }
}
