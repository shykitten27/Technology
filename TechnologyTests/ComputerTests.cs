
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Technology;

namespace Technology
{
    [TestClass]
    public class ComputerTests
    {
        // Create test_computer for testing
        Computer test_computer1;
        Computer test_computer2;

        [TestInitialize]
        public void CreateComputerObject()
        {
            test_computer = new Computer("Gaming", "Ben", 2020, 16.0, "Windows 10", false); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
            test_computer2 = new Computer("School", "Erica", 2019, 16.0, "Windows 10", false); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
        }

        [TestMethod]
        public void TestSettingDeviceId()
        {
            Assert.IsFalse(test_computer1.DeviceId == test_computer1.DeviceId); //Ids are NOT equal
            Assert.IsTrue(test_computer2.DeviceId == (test_computer1.DeviceId + 1)); //second id is greater by 1
        }

        [TestMethod]
        //assertions for each property
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(test_computer1.Name, "Gaming");
            Assert.AreEqual(test_computer1.Owner, "Ben");
            Assert.AreEqual(test_computer1.YearMade, 2020);
            Assert.AreEqual(test_computer1.RAM, 16.0);
            Assert.AreEqual(test_computer1.OperatingSystem, "Windows 10");
            Assert.IsFalse(test_computer1.DeviceStatus);
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOn()
        {
            Assert.IsTrue(test_computer1.DeviceStatus);
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOff()
        {
            Assert.IsFalse(test_computer1.DeviceStatus);
        }
    }
}
