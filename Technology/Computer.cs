using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Computer : AbstractEntity
    {

        public string Name { get; set; }
        public string Owner { get; set; }
        public int YearMade { get; set; }
        public double RAM { get; set; }
        public string OperatingSystem { get; set; }
        public bool DeviceStatus { get; set; }
     

        public Computer(string name, string owner, int yearMade, double ram, string operatingSystem, bool deviceStatus) : base()
        {
            Name = name;
            Owner = owner;
            YearMade = yearMade;
            RAM = ram;
            OperatingSystem = operatingSystem;
            DeviceStatus = deviceStatus;
        }

        public void PowerOn()
        {
            DeviceStatus = true;
        }

        public void PowerOff()
        {
            DeviceStatus = false;
        }
    }
}