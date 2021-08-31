
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace Technology
{
    class ComputerTests
    {
        // add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(1, 1, .001);
        }

        // Create test_computer for testing
        Computer test_computer;

        [TestInitialize]
        public void CreateComputerObject()
        {
            test_computer = new Computer("Gaming", "Ben", 2020, 16.0, "Windows 10", false); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
        }
        
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOn()
        {
            Assert.IsTrue(test_computer.DeviceStatus);
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOff()
        {
            Assert.IsFalse(test_computer.DeviceStatus);
        }
    }
}
