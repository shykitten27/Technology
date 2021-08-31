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
            Console.WriteLine(testComputer.Owner);
            Console.WriteLine(testSmartPhone.DeviceStatus);
            Console.WriteLine(testLaptop.Trackpad);
            Console.WriteLine(testLaptop.OperatingSystem);
            testLaptop.PowerOn();
            Console.WriteLine(testLaptop.DeviceStatus);
            Console.WriteLine(testSmartPhone.Silence());
            testSmartPhone.PowerOff();
            Console.WriteLine(testSmartPhone.DeviceStatus);
        }
    }
}
