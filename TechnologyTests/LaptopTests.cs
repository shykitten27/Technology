using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTest
{
    class LaptopTests
    {
        // add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(1, 1, .001);
        }

        // Create test_computer for testing
        Laptop test_laptop;

        [TestInitialize]
        public void CreateLaptopObject()
        {
            test_laptop = new Laptop("Dell", "Donna", 2021, 16.0, "Windows 10", false, "BIGtrackpad"); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
        }

        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOn()
        {
            Assert.IsTrue(test_laptop.DeviceStatus);
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOff()
        {
            Assert.IsFalse(test_laptop.DeviceStatus);
        }
    }
}
