using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HaromszogProgram.Tests
{

    [TestClass()]
    public class HaromszogTests
    {
        Haromszog haromszog;

        [TestInitialize]
        public void SetUp()
        {
            haromszog = new Haromszog(2,2,2);
        }

        [TestMethod()]
        public void KeruletTest()
        {
            double e = haromszog.Kerulet();
            Assert.AreEqual(6, e);
            //Assert.Fail();
        }

        public void SzekeszthetoTest()
        {
            hsz = new Haromszog(1, 2, 3);
            Assert.IsTrue(false);
        }
    }
}