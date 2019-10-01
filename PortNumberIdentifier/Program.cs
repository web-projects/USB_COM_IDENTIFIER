using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortNumberIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Win32DeviceMgmt.DeviceInfo> devices = Win32DeviceMgmt.GetAllCOMPorts();
            foreach(var device in devices)
            {
                Console.WriteLine($"DEVICE '{device.description}' ON PORT: {device.name}");
            }
        }
    }
}
