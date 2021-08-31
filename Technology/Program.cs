using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer testComputer = new Computer("Gaming", "Ben", 2020, 16.0, "Windows 10", false);
            Laptop testLaptop = new Laptop("Dell", "Donna", 2021, 16.0, "Windows 10", false, "BIGtrackpad");
            SmartPhone testSmartPhone = new SmartPhone("Galaxy S21", "Donna", 2021, 8.0, "Android 11", true, "T-Mobile");
            Console.WriteLine("Computer Owner: " + testComputer.Owner);
            Console.WriteLine("SmartPhone status: " + testSmartPhone.DeviceStatus);
            Console.WriteLine("Laptop property: " + testLaptop.Trackpad);
            Console.WriteLine("Laptop OS: " + testLaptop.OperatingSystem);
            testLaptop.PowerOn();
            Console.WriteLine("Laptop status after PowerOn(): " + testLaptop.DeviceStatus);
            Console.WriteLine("SmartPhone Silence returns: " + testSmartPhone.Silence());
            testSmartPhone.PowerOff();
            Console.WriteLine("SmartPhone status: " + testSmartPhone.DeviceStatus);
        }
    }
}
