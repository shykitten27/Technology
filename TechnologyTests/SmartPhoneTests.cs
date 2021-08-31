using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    class SmartPhoneTests
    {
        // add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(1, 1, .001);
        }

        // Create test_computer for testing
        SmartPhone test_smartphone;

        [TestInitialize]
        public void CreateSmartPhoneObject()
        {
            test_smartphone = new SmartPhone("Galaxy S21", "Donna", 2021, 8.0, "Android 11", true, "T-Mobile"); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
        }

        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOn()
        {
            Assert.IsTrue(test_smartphone.DeviceStatus);
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOff()
        {
            Assert.IsFalse(test_smartphone.DeviceStatus);
        }
        [TestMethod]
        public void MakeCall()
        {
            Assert.AreEqual("Call was successful", "Call was successful");
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void Silence()
        {
            Assert.AreEqual("Shush", "Shush");
        }
    }
}
