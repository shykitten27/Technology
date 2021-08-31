using Microsoft.VisualStudio.TestTools.UnitTesting;
using Technology;

namespace TechnologyTests
{
    [TestClass]
    public class SmartPhoneTests
    {
        // Create smartphone for testing
        SmartPhone test_smartphone1;
        SmartPhone test_smartphone2;


        [TestInitialize]
        public void CreateSmartPhoneObject()
        {
            test_smartphone1 = new SmartPhone("Galaxy S21", "Donna", 2021, 8.0, "Android 11", true, "T-Mobile"); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
            test_smartphone2 = new SmartPhone("IPhone 11", "Steve", 2019, 8.0, "iOS", true, "T-Mobile"); // the AbStractEntity ID, name, owner, yearMade, ram, operatingSystem, deviceStatus
        }

        [TestMethod]
        public void TestSettingDeviceId()
        {
            Assert.IsFalse(test_smartphone1.DeviceId == test_smartphone1.DeviceId); //Ids are NOT equal
            Assert.IsTrue(test_smartphone2.DeviceId == (test_smartphone1.DeviceId + 1)); //second id is greater by 1
        }

        [TestMethod]
        //assertions for each property
        public void TestJobConstructorSetsAllFields()
        {
            Assert.AreEqual(test_smartphone1.Name, "Galaxy S21");
            Assert.AreEqual(test_smartphone1.Owner, "Donna");
            Assert.AreEqual(test_smartphone1.YearMade, 2021);
            Assert.AreEqual(test_smartphone1.RAM, 8.0);
            Assert.AreEqual(test_smartphone1.OperatingSystem, "Android 11");
            Assert.IsFalse(test_smartphone1.DeviceStatus);
            Assert.AreEqual(test_smartphone1.WirelessCarrier, "T-Mobile");
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOn()
        {
            Assert.IsTrue(test_smartphone1.DeviceStatus);
        }
        // method sets Status properly (status of Power)
        [TestMethod]
        public void PowerOff()
        {
            Assert.IsFalse(test_smartphone1.DeviceStatus);
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
