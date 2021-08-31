using System;
using System.Collections.Generic;
using System.Text;

namespace Technology
{
    public class SmartPhone : Computer
    {
        public string WirelessCarrier { get; set; }

        public SmartPhone(string name, string owner, int yearMade, double ram, string operatingSystem, bool deviceStatus, string wirelessCarrier) : base(name, owner, yearMade, ram, operatingSystem, deviceStatus)
        {
            WirelessCarrier = wirelessCarrier;
        }

        public string MakeACall()
        {
            return "Call was successful";
        }

        public string Silence()
        {
            return "Shush";
        }
    }
}