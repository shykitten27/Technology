using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTest
{
    [TestClass]
    public class LaptopTests
    {
        // Create laptop for testing
        Laptop test_laptop1;
        Laptop test_laptop2;

        [TestInitialize]
        public void CreateLaptopObject()
        {
            test_laptop1 = new Laptop("Dell", "Donna", 2021, 16.0, "Windows 10", false, "BIGtrackpad"); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
            test_laptop2 = new Laptop("Microsoft", "Erica", 2019, 16.0, "Windows 10", false, "smalltrackpad"); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
        }

        [TestMethod]
        public void TestSettingDeviceId()
        {
            Assert.IsFalse(test_laptop1.DeviceId == test_laptop1.DeviceId); //Ids are NOT equal
            Assert.IsTrue(test_laptop2.DeviceId == (test_laptop1.DeviceId + 1)); //second id is greater by 1
        }

        [TestMethod]
        //assertions for each property
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(test_laptop1.Name, "Dell");
            Assert.AreEqual(test_laptop1.Owner, "Donna");
            Assert.AreEqual(test_laptop1.YearMade, 2021);
            Assert.AreEqual(test_laptop1.RAM, 16.0);
            Assert.AreEqual(test_laptop1.OperatingSystem, "Windows 10");
            Assert.IsFalse(test_laptop1.DeviceStatus);
            Assert.AreEqual(test_laptop1.Trackpad, "BIGtrackpad");
        }

        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOn()
        {
            Assert.IsTrue(test_laptop1.DeviceStatus);
        }

        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOff()
        {
            Assert.IsFalse(test_laptop1.DeviceStatus);
        }
    }
}
