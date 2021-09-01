using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class Laptop : Computer
    {
        public string Trackpad { get; set; }
        public Laptop(string name, string owner, int yearMade, double ram, string operatingSystem, bool deviceStatus, string trackpad) : base(name, owner, yearMade, ram, operatingSystem, deviceStatus)
        {
            Trackpad = trackpad;
        }
    }
}